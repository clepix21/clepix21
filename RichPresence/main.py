from pypresence import Presence
import time

id = '884845004042960918'  # ID
RPC = Presence(id)  
RPC.connect() 
print(RPC.update(state="Kalash est chargé", details="test,SUPER TEST !", large_image="1", small_image="2"))

while True: 
    time.sleep(1) 