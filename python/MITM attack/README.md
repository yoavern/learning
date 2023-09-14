# ARP Spoofing Attack Script

## Overview

This Python script is a demonstration of an ARP Spoofing (Man-in-the-Middle) attack using Scapy. ARP Spoofing is a technique that allows an attacker to intercept and manipulate network traffic between two parties. It can be used for various purposes, including network monitoring, eavesdropping, or even malicious activities.

**Note:** This script is for educational purposes only. Unauthorized use of ARP Spoofing is illegal and unethical. Ensure you have permission to use this script on the target network.

## Prerequisites

Before running the script, make sure you have the following prerequisites:

- Python 3.x
- Scapy library (`pip install scapy`)
- Administrative or root privileges (for packet sniffing and manipulation)
- An understanding of how ARP Spoofing works and its implications

## Usage

1. Clone this repository to your local machine:

2.   ```bash
     cd arp-spoofing-script

3.   ```bash
     sudo python arp_spoof.py

4.  Follow the on-screen prompts to specify the target IP address, network interface, and gateway IP address.

5.  The script will start ARP poisoning the target, intercepting and displaying network packets between the victim   and the gateway.

6. To stop the attack, press Ctrl+C. The script will attempt to restore the network to its normal state.

**Note:** Make sure to enable IP forwarding on your machine for the attack to work properly.

## Disclaimer

This script is intended for educational and research purposes only. The misuse of ARP Spoofing or any other hacking technique for illegal activities is strictly prohibited. The author is not responsible for any misuse or damage caused by this script.

