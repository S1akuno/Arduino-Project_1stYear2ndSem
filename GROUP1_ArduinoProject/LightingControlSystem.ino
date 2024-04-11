void LCSsetup(){
  ///////////////////////  LIGHTING CONTROL SYSTEM SETUP  ///////////////////////////////////////
  pinMode(LCS_ledBlue, OUTPUT);
  pinMode(LCS_ledRed, OUTPUT);
  pinMode(LCS_ledYellow, OUTPUT);
  pinMode(LCS_ledWhite, OUTPUT);
  pinMode(LCS_blueButton, INPUT);
  pinMode(LCS_redButton, INPUT);
  pinMode(LCS_yellowButton, INPUT);
  pinMode(LCS_whiteButton, INPUT);
  pinMode(LCS_turnOFFButton, INPUT);
}

void LCSloop(){
    ////////////////////////  LIGHTING SYSTEM CONTROLLER  /////////////////////////////////////////
  // TURN ON BUTTON   -   Turns on all LED
  if(digitalRead(LCS_turnONButton) == HIGH){
    LCS_blue = true;
    LCS_red = true;
    LCS_yellow = true;
    LCS_white = true;
    lcd.clear();
    Serial.println("ALL LEDs turned ON\n");
    lcd.setCursor(0,0);
    lcd.print("ALL LEDs turned");
    lcd.setCursor(7,1);
    lcd.print("ON");    

    txtMessage("All Lights Are ON");
  }
  // TURN OFF BUTTON   -   Turns off all LED
  else if (digitalRead(LCS_turnOFFButton) == HIGH){ 
    LCS_blue = false;
    LCS_red = false;
    LCS_yellow = false;
    LCS_white = false;
    lcd.clear();
    Serial.println("ALL LEDs turned OFF\n");
    lcd.setCursor(0,0);
    lcd.print("ALL LEDs turned");
    lcd.setCursor(7,1);
    lcd.print("OFF");


    txtMessage("All Lights Are OFF");

  }
  // White  Button    -   Turns on White LED
  else if (digitalRead(LCS_whiteButton) == HIGH){
    if(LCS_white == false){
      LCS_white = true;
      lcd.clear();
      Serial.println("White LED turned ON\n");
      lcd.setCursor(2,0);
      lcd.print("White LED is");
      lcd.setCursor(7,1);
      lcd.print("ON");

      txtMessage("White LED turned ON");    
    }
    else {   
      LCS_white = false;
      lcd.clear();
      Serial.println("White LED turned OFF\n");
      lcd.setCursor(2,0);
      lcd.print("White LED is");
      lcd.setCursor(6,1);
      lcd.print("OFF");

      txtMessage("White LED turned OFF");
    }  
  }
  // Red Button    -   Turns on Red LED
  else if (digitalRead(LCS_redButton) == HIGH){
    if(LCS_red == false){
      LCS_red = true;
      lcd.clear();
      Serial.write("Red LED turned ON\n");
      lcd.setCursor(3,0);
      lcd.print("Red LED is");
      lcd.setCursor(7,1);
      lcd.print("ON");
      
      //txtMessage("Red LED turned ON");  
    }
    else {
      LCS_red = false;
      Serial.write("Red LED turned OFF\n");
      lcd.clear();
      lcd.setCursor(3,0);
      lcd.print("Red LED is");
      lcd.setCursor(7,1);
      lcd.print("OFF");

      //txtMessage("Red LED turned OFF");
    }
  }
  // Blue Button    -   Turns on Blue LED
  else if (digitalRead(LCS_blueButton) == HIGH){
    if(LCS_blue == false){
      LCS_blue = true;
      Serial.println("Blue LED turned ON\n");
      lcd.clear();
      lcd.setCursor(3,0);
      lcd.print("Blue LED is");
      lcd.setCursor(7,1);
      lcd.print("ON");

      txtMessage("Blue LED turned ON");
    }
    else if (LCS_blue == true) {  
      LCS_blue = false;
      Serial.println("Blue LED turned OFF\n");
      lcd.clear();
      lcd.setCursor(3,0);
      lcd.print("Blue LED is");
      lcd.setCursor(7,1);
      lcd.print("OFF");

      txtMessage("Blue LED turned OFF");
    }
  }
  // Yellow Button     -   Turns on Yellow LED
  else if (digitalRead(LCS_yellowButton) == HIGH){
    if(LCS_yellow == false){
      LCS_yellow = true;
      Serial.println("Yellow LED turned ON\n");
      lcd.clear();
      lcd.setCursor(2,0);
      lcd.print("Yellow LED is");
      lcd.setCursor(7,1);
      lcd.print("ON");

      txtMessage("Yellow LED turned ON");
    }
    else {
      LCS_yellow = false;
      Serial.println("Yellow LED turned OFF\n");
      lcd.clear();
      lcd.setCursor(2,0);
      lcd.print("Yellow LED is");
      lcd.setCursor(7,1);
      lcd.print("OFF");

      txtMessage("Yellow LED turned OFF");
    }
  }

  // This will control the LEDs
  if (LCS_red == true){
    digitalWrite(LCS_ledRed, HIGH);
  }
  else if (LCS_red == false){
    digitalWrite(LCS_ledRed, LOW);
  }
  if (LCS_white == true){
    digitalWrite(LCS_ledWhite, HIGH);
  }
  else if (LCS_white == false){
    digitalWrite(LCS_ledWhite, LOW);
  }
  if (LCS_blue == true){
    digitalWrite(LCS_ledBlue, HIGH);
  }
  else if (LCS_blue == false){
    digitalWrite(LCS_ledBlue, LOW);
  }
  if (LCS_yellow == true){
    digitalWrite(LCS_ledYellow, HIGH);
  }
  else if (LCS_yellow == false){
    digitalWrite(LCS_ledYellow, LOW);
  }
}