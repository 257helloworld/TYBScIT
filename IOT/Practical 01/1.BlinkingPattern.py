# Blinking LED Pattern.

import RPi.GPIO as GPIO
from time import sleep

pins = [29, 31, 33, 35]
GPIO.setmode(GPIO.BOARD)

for pin in pins:
    GPIO.setup(pin, GPIO.OUT)

try:
    while(True):
        # Each LED - on for 2 secs.
        for pin in pins:    
            GPIO.output(pin, GPIO.HIGH)
            sleep(2)
            GPIO.output(pin, GPIO.LOW)
            sleep(2)

except KeyboardInterrupt:
    for pin in pins:
        GPIO.output(pin, GPIO.LOW)
    GPIO.cleanup()
