# Program to store unique identification number into the tag.

import RPi.GPIO as GPIO
from mfrc522 import SimpleMFRC522

writer = SimpleMFRC522()

try:
    data = input("Enter data: ")
    print("Now place your tag to write.")
    writer.write(data)
    print("Written")
finally:
    GPIO.cleanup()