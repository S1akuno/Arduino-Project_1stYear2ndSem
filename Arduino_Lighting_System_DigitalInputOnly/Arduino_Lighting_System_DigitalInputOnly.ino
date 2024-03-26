///////////////////////  LIGHTING CONTROL SYSTEM  ////////////////////////////

#define blackButton 2
#define whiteButton 3
#define yellowButton 4
#define blueButton 5
#define redButton 6

#define ledWhite 7
#define ledYellow 8
#define ledBlue 9
#define ledRed 10

boolean blue = false, red = false, yellow = false, white = false, totalOff = true, totalOn = false;
// false means OFF

///////////////////////  EARTHQUAKE ALARM SYSTEM   ////////////////////////////
#define buzzer1 22
#define ledBlue1 24
#define blueButton1 26
#define ledRed1 28
#define redButton1 30
#define buzzer2 32

boolean redIndicator = false, blueIndicator = false;

/*///////////////////////  FIRE DETECTION ALARM SYSTEM  ////////////////////////////

#define buzzer3 3
int flameSensor1 = 2;
*/
void setup() {
  ///////////////////  LIGHTING SYSTEM  ////////////////////////////////
  pinMode(ledBlue, OUTPUT);
  pinMode(ledRed, OUTPUT);
  pinMode(ledYellow, OUTPUT);
  pinMode(ledWhite, OUTPUT);
  pinMode(blueButton, INPUT);
  pinMode(redButton, INPUT);
  pinMode(yellowButton, INPUT);
  pinMode(whiteButton, INPUT);
  pinMode(blackButton, INPUT);


///////////////////////  EARTHQUAKE ALARM SYSTEM   ////////////////////////////
  pinMode(buzzer1, OUTPUT);
  pinMode(buzzer2, OUTPUT);
  pinMode(ledBlue1, OUTPUT);
  pinMode(ledRed1, OUTPUT);
  pinMode(blueButton1, INPUT);
  pinMode(redButton1, INPUT);
  
  Serial.begin(9600);
/*///////////////////////  FIRE DETECTION ALARM SYSTEM  ////////////////////////////
  pinMode(buzzer3, OUTPUT);
  pinMode(flameSensor1, INPUT);
  Serial.println("");
  Serial.println("COMPONENTS WARMING UP, PLEASE WAIT FOR 20s");
 // delay(20000);
  Serial.println("COMPONENTS READY!");
*/

}

void loop() {
////////////////////////  LIGHTING SYSTEM  ////////////////////////////////////////////

  //Validation if the LEDs are turned off
  if (red == false || blue == false || yellow == false || white == false){
    totalOff = true;
  }
  if (red == true && blue == true && yellow == true && white == true){
    totalOff = false;
  }
  // Black button Function
  if(digitalRead(blackButton) == HIGH){
    if(totalOff == true){    //If the LEDs are all turned off, it will turn the LEDs ON
      blue = true;
      red = true;
      yellow = true;
      white = true;
      totalOff = false;     // marks that the LEDs are turned ON
      Serial.println("ALL LEDs turned ON");

    }
    else if (totalOff == false){ // If the LED'S are all turned ON, it will turn the LEDs OFF
      blue = false;
      red = false;
      yellow = false;
      white = false;
      totalOff = true;          // marks that the LED's are off
      Serial.println("ALL LEDs turned OFF");

    }
  }
  // White  Button
  else if (digitalRead(whiteButton) == HIGH){
    if(white == false){
      white = true;
      Serial.println("White LED turned ON");
    }
    else {
      
      white = false;
      Serial.println("White LED turned OFF");
    }
  }
  // Red Button
  else if (digitalRead(redButton) == HIGH){
    if(red == false){
      red = true;
      Serial.println("Red LED turned ON");
    }
    else {
      
      red = false;
      Serial.println("Red LED turned OFF");
    }
  }
  // Blue Button
  else if (digitalRead(blueButton) == HIGH){
    if(blue == false){
      blue = true;
      Serial.println("Blue LED turned ON");
    }
    else if (blue == true) {  
      blue = false;
      Serial.println("Blue LED turned OFF");
    }
  }
  // Yellow Button
  else if (digitalRead(yellowButton) == HIGH){
    if(yellow == false){
      yellow = true;
      Serial.println("Yellow LED turned ON");
    }
    else {
      yellow = false;
      Serial.println("Yellow LED turned OFF");
    }
  }
  ////////////////////////  CONDITIONALS  ///////////////////////////////////
  if (red == true){
    digitalWrite(ledRed, HIGH);
  }
  else if (red == false){
    digitalWrite(ledRed, LOW);
  }
  if (white == true){
    digitalWrite(ledWhite, HIGH);
  }
  else if (white == false){
    digitalWrite(ledWhite, LOW);
  }
  if (blue == true){
    digitalWrite(ledBlue, HIGH);
  }
  else if (blue == false){
    digitalWrite(ledBlue, LOW);
  }
  if (yellow == true){
    digitalWrite(ledYellow, HIGH);
  }
  else if (yellow == false){
    digitalWrite(ledYellow, LOW);
  }


///////////////////////  EARTHQUAKE SYSTEM DECLARATION  ////////////////////////////
  if (digitalRead(redButton1) == HIGH) {  
    if(redIndicator == false){      // If the red button is clicked and the indicators are off, this will turn the alarm ON
      redIndicator = true;
      blueIndicator = false;    // turns off the other alarm if it is turned on
      Serial.println("EARHTQUAKE ALARM ACTIVATED!!");
    }
    else if (redIndicator == true){ // If the red button is clicked and the indicators are ON, this will turn the alarm OFF
      redIndicator = false;
      Serial.println("EARHTQUAKE ALARM DEACTIVATED!!");
    }
  } 
  else if (digitalRead(blueButton1) == HIGH) {
    if(blueIndicator == false){
      redIndicator = false;
      blueIndicator = true;
      Serial.println("EARHTQUAKE DRILL ALARM ACTIVATED!!");
    }
    else if (blueIndicator == true){
      blueIndicator = false;
      Serial.println("EARHTQUAKE DRILL ALARM DEACTIVATED!!");
    }
  } 

  if(redIndicator == true){
    digitalWrite(ledRed1, HIGH);
    tone(buzzer2, 1000);
    delay(500);
    tone(buzzer2, 500);
    delay(500);
  }
  else if (redIndicator == false){
    digitalWrite(ledRed1, LOW);
    noTone(buzzer2);
  }

  if(blueIndicator == true){
    digitalWrite(ledBlue1, HIGH);
    tone(buzzer1, 1000);
    delay(200);
    tone(buzzer1, 100);
    delay(100);
    tone(buzzer1, 800);
    delay(200);
    tone(buzzer1, 300);
    delay(100);
  }
  else if (blueIndicator == false){
    digitalWrite(ledBlue1, LOW);
    noTone(buzzer1);
  }

  ///////////////////////  FIRE DETECTION ALARM SYSTEM  ////////////////////////////
 /* int smokeSensorValue = analogRead(A0);
  if (smokeSensorValue >= 400){
    Serial.print("Sensor Value:");
    Serial.print(smokeSensorValue);
    Serial.print(" | Smoke Detected !!!");
    Serial.println("");

    digitalWrite(buzzer3, HIGH);
    delay(1000);
  }
  else{
    Serial.print("Smoke Sensor Value: ");
    Serial.print(smokeSensorValue);
    Serial.println("");
    digitalWrite(buzzer3, LOW);

  }
    int flame = analogRead(A2);
  if (digitalRead(flameSensor1) == HIGH){
    Serial.println("SUNOOOOOGGGGG!!!");
  }
  if(digitalRead(flameSensor1) == LOW){
    Serial.println("WALA SUNOG!!");
    delay(2000);
  }
  Serial.println(flame);
  */

  
  

delay(200);
}


