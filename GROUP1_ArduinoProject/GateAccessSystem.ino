void GASinitialization(){
  
}
void GASsetup(){
  ///////////////////////  GATE ACCESS SYSTEM SETUP  ////////////////////////////////////////////
    servoMain.attach(34); //Location of the pin
    servoMain.write(0); //set initial position of servo
    pinMode(trigpin, OUTPUT);
    pinMode(echopin, INPUT);
}

void GASloop(){
  ////////////////////////  GATE ACCESS SYSTEM CONTROLLER  //////////////////////////////////////
    
    digitalWrite(trigpin, LOW);   // Clears the trigpin
    delay(20);
    digitalWrite(trigpin, HIGH); // Sets the trigpin high for 10 microseconds
    delayMicroseconds(10);
    digitalWrite(trigpin, LOW); 
    duration = pulseIn(echopin, HIGH);
    cm =  (duration/58.82);
    distance = cm;

    if (distance < 20 && !gateOpen) {
      lcd.clear();
    lcd.setCursor(2,0);
    lcd.print("Gate Opened!");
    servoMain.write(90);
    
    gateOpen = true; // Set gateOpen flag
    Serial.println("Gate Open\n");
    // delay(1000);
    delay(2000);
     } 
     else if (distance >= 20 && gateOpen) { // Use "else if" to handle both conditions mutually exclusively
      lcd.clear();
    lcd.setCursor(2,0);
    servoMain.write(0);
    Serial.println("Gate Close\n");
    gateOpen = false; // Reset gateOpen flag
      lcd.print("Gate Closed!");
    delay(2000);
   }
}