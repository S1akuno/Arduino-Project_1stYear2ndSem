void GSMinitialization(){
  
}


void txtMessage(String message){
    // GSM PROCESS
  myGSM.println("AT+CMGF=1"); // Set SMS mode to text
  delay(500);
  for (int i = 0; i < sizeof(numbers) / sizeof(numbers[0]); i++) {
    myGSM.print("AT+CMGS=\"");
    myGSM.print(numbers[i]);
    myGSM.println("\""); // Set the recipient number
    delay(1000); // Increased delay to ensure the GSM module is ready to receive the message
    myGSM.println(message); // The SMS text you want to send
    delay(100);
    myGSM.println((char)26); // Send the Ctrl+Z character to indicate the end of the message
    delay(3000); // Increased delay to ensure the GSM module has finished sending the message
    Serial.println("Message Sent to: " + numbers[i]);
    delay(1000); // Delay between sending messages
  }
}