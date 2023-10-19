# Program to identify the tag.

import RPi.GPIO as GPIO
from mfrc522 import SimpleMFRC522

reader = SimpleMFRC522()

try:
    id, data = reader.read()
    print("Id: {}".format(id))
    print("Data: {}".format(data))
finally:
    GPIO.cleanup()