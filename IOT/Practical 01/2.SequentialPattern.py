# Sequential On / Off LED Pattern.

import RPi.GPIO as GPIO
from time import sleep

pins = [29, 31, 33, 35]
GPIO.setmode(GPIO.BOARD)

for pin in pins:
    GPIO.setup(pin, GPIO.OUT)

try:
    while(True):
        # Turn LED on one by one after 1 sec. and again off in the reverse seq.
        for pin in pins:
            GPIO.output(pin, GPIO.HIGH)
            sleep(1)
        for pin in reversed(pins):
            GPIO.output(pin, GPIO.LOW)
            sleep(1)

except KeyboardInterrupt:
    for pin in pins:
        GPIO.output(pin, GPIO.LOW)
    GPIO.cleanup()