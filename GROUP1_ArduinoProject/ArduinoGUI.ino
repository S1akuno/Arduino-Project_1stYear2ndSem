///////////////////////  INITIALIZATION OF LIGHTING CONTROL SYSTEM  /////////////////////////////
  // Assigning Digital Input PIN numbers
  #define LCS_turnONButton 2
  #define LCS_turnOFFButton 3
  #define LCS_whiteButton 4
  #define LCS_yellowButton 5
  #define LCS_blueButton 6
  #define LCS_redButton 7
  #define LCS_ledWhite 8
  #define LCS_ledYellow 9
  #define LCS_ledBlue 10
  #define LCS_ledRed 11



void ArduinoGUIloop(){
////////////////////////  ARDUINO GUI  ////////////////////////////////////////////////////////
  if (Serial.available()){
    String data = Serial.readString();




    if(Serial.read() == "p"){
      txtMessage("hello");
    }
  ///////////////////  LIGHTING SYSTEM  ////////////////////////////////
    if(data == "redLED"){
      if(LCS_red == false){
        LCS_red = true;
        Serial.write("Red LED turned ON\n");
        txtMessage("Red LED turned ON");  
      }
      else {
        LCS_red = false;
        Serial.write("Red LED turned OFF\n");
        txtMessage("Red LED turned OFF");          
      }
    }
    else if (data == "blueLED"){
      if(LCS_blue == false){
        LCS_blue = true;
        Serial.println("Blue LED turned ON\n");
        txtMessage("Blue LED turned ON");   
      }
      else if (LCS_blue == true) {  
        LCS_blue = false;
        Serial.println("Blue LED turned OFF\n");
        txtMessage("Blue LED turned OFF");  
      }
    }
    else if (data == "yellowLED"){
      if(LCS_yellow == false){
        LCS_yellow = true;
        Serial.println("Yellow LED turned ON\n");
        txtMessage("Yellow LED turned ON");  
      }
      else {
        LCS_yellow = false;
        Serial.println("Yellow LED turned OFF\n");
        txtMessage("Yellow LED turned OFF");  
      }
    }
    else if (data == "whiteLED"){
      if(LCS_white == false){
        LCS_white = true;
        Serial.println("White LED turned ON\n");
        txtMessage("White LED turned ON");  
      }
      else {
        LCS_white = false;
        Serial.println("White LED turned OFF\n");
        txtMessage("White LED turned OFF");  
      }
    }
    else if (data == "onAllLED"){
        LCS_blue = true;
        LCS_red = true;
        LCS_yellow = true;
        LCS_white = true;
        Serial.println("ALL LEDs turned ON\n");
        txtMessage("ALL LEDs turned ON");  
    }
    else if (data == "offAllLED"){
        LCS_blue = false;
        LCS_red = false;
        LCS_yellow = false;
        LCS_white = false;
        Serial.println("ALL LEDs turned OFF\n");
        txtMessage("ALL LEDs turned OFF"); 
    }

  ///////////////////////////  EARTHQUAKE ALARAM SYSTEM  ///////////////////////
    if(data == "Emergency"){
      if(EQAS_redIndicator == false){      // If the LCS_red button is clicked and the indicators are off, this will turn the alarm ON
        EQAS_redIndicator = true;
        EQAS_blueIndicator = false;    // turns off the other alarm if it is turned on
        Serial.println("EARTHQUAKE ALARM ACTIVATED!!\n");
      }
      else if (EQAS_redIndicator == true){ // If the LCS_red button is clicked and the indicators are ON, this will turn the alarm OFF
        EQAS_redIndicator = false;
        Serial.println("EARTHQUAKE ALARM DEACTIVATED!!\n");
      }  
    }
    if(data == "Drill"){
      if(EQAS_blueIndicator == false){
        EQAS_redIndicator = false;
        EQAS_blueIndicator = true;
        Serial.println("EARTHQUAKE DRILL ALARM ACTIVATED!!\n");
      }
      else if (EQAS_blueIndicator == true){
        EQAS_blueIndicator = false;
        Serial.println("EARTHQUAKE DRILL ALARM DEACTIVATED!!\n");
      }
    }
  }
}