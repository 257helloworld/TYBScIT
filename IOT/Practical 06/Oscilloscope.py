import time
import matplotlib.pyplot as plt

#import numpy
from drawnow import *
import Adafruit_ADS1x15 as Adafruit

adc = Adafruit.ADS1115()

GAIN = 1
val = []
plt.ion()
# Start continuous ADC conversions on channel 0 using the previous gain value.
adc.start_adc(0, gain=GAIN)
print('Reading Channel 0')

# Figure Function
def makeFig():
    plt.ylim(-5000,5000)
    plt.title('Oscilloscope')
    plt.grid(True)
    plt.ylabel('ADC outputs')
    # ro- represents red circle and line.
    plt.plot(val, 'ro-', label='Channel 0')
    plt.legend(loc='lower right')

while(True):
    # Read the last ADC conversion value and print it out.
    value = adc.get_last_result()
    print('Channel 0: {0}'.format(value))
    # Sleep for half a second.
    time.sleep(0.5)
    # Add new value to 'val' array
    val.append(int(value))
    # Draw figure
    drawnow(makeFig)

