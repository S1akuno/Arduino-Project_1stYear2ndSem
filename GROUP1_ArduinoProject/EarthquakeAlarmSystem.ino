
///////////////////////  INITIALIZATION OF EARTHQUAKE ALARM SYSTEM   ////////////////////////////
   // Assigning Digital Input PIN numbers
  #define EQAS_buzzer1 22
  #define EQAS_ledBlue 24
  #define EQAS_blueButton 26
  #define EQAS_ledRed 28
  #define EQAS_redButton 30
  #define EQAS_buzzer2 32

 

void EASsetup(){
  ///////////////////////  EARTHQUAKE ALARM SYSTEM SETUP  ///////////////////////////////////////
    pinMode(EQAS_buzzer1, OUTPUT);
    pinMode(EQAS_buzzer2, OUTPUT);
    pinMode(EQAS_ledBlue, OUTPUT);
    pinMode(EQAS_ledRed, OUTPUT);
    pinMode(EQAS_blueButton, INPUT);
    pinMode(EQAS_redButton, INPUT);  
  
}

void EASloop(){
  ////////////////////////  EARTHQUAKE SYSTEM CONTROLLER  ///////////////////////////////////////
    if (digitalRead(EQAS_redButton) == HIGH) {  
      if(EQAS_redIndicator == false){      // If the LCS_red button is clicked and the indicators are off, this will turn the alarm ON
        EQAS_redIndicator = true;
        EQAS_blueIndicator = false;    // turns off the other alarm if it is turned on
        Serial.println("EARTHQUAKE ALARM ACTIVATED!!");
        txtMessage("EARTHQUAKE ALARM ACTIVATED!!");
      }
      else if (EQAS_redIndicator == true){ // If the LCS_red button is clicked and the indicators are ON, this will turn the alarm OFF
        EQAS_redIndicator = false;
        Serial.println("EARTHQUAKE ALARM DEACTIVATED!!");
        txtMessage("EARTHQUAKE ALARM DEACTIVATED!!");
      }
    } 
    else if (digitalRead(EQAS_blueButton) == HIGH) {
      if(EQAS_blueIndicator == false){
        EQAS_redIndicator = false;
        EQAS_blueIndicator = true;
        Serial.println("EARHTQUAKE DRILL ALARM ACTIVATED!!");
        txtMessage("EARTHQUAKE DRILL ALARM ACTIVATED!!");
      }
      else if (EQAS_blueIndicator == true){
        EQAS_blueIndicator = false;
        Serial.println("EARHTQUAKE DRILL ALARM DEACTIVATED!!");
        txtMessage("EARTHQUAKE DRILL ALARM DEACTIVATED!!");
      }
    } 

    if(EQAS_redIndicator == true){
      digitalWrite(EQAS_ledRed, HIGH);
      tone(EQAS_buzzer2, 1000);
      delay(500);
      tone(EQAS_buzzer2, 500);
      delay(500);

    }
    else if (EQAS_redIndicator == false){
      digitalWrite(EQAS_ledRed, LOW);
      noTone(EQAS_buzzer2);
    }
    if(EQAS_blueIndicator == true){
      digitalWrite(EQAS_ledBlue, HIGH);
      tone(EQAS_buzzer1, 1000);
      delay(200);
      tone(EQAS_buzzer1, 100);
      delay(100);
      tone(EQAS_buzzer1, 800);
      delay(200);
      tone(EQAS_buzzer1, 300);
      delay(100);

    }
    else if (EQAS_blueIndicator == false){
      digitalWrite(EQAS_ledBlue, LOW);
      noTone(EQAS_buzzer1);
    }
  
}