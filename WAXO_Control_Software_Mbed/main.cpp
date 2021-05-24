#include "mbed.h"
#include <stdio.h>
#include "Servo.h"
 
//Initialize pins
AnalogIn   ain(p16);
Serial device(p28,p27);
Serial pc(USBTX, USBRX);
Servo actuator(p21);
 
//Variables
Timer t;
float gaitPeriod[6];
int startTime = 0;
int gaitCounter = 0;
float gaitPeriodMean = 0.00f;
float inputReading = 0.00f;
float percentage = 0.00f;
//float actuationPercentage = 30.0f;
int actuationPercentage = 30;
//char buffer[2];
int inByte;
 
Servo myServo(p21);
PwmOut dcMotor(p22);
 
//function to calculate the mean 
float mean (float tab[], int size){
    float sum = 0.00f;
    for (int i=1;i<size;i++){
        sum += tab[i];
    }
    return sum/(size-1);
}
 
//Servo Motor function
void ServoActuaute(){
    myServo.write(0);
    wait(0.4);
    myServo.write(0.7);  
}
 
int main(void)
{
    device.baud(57600);
    myServo.write(0);
    
    while (1) {
        //Check for Serial Event
        if (device.readable()){
            char command = device.getc();
            /*
            Menu:
            Case a: get the mean of gait period over 5 cycles
            Case b: use the calculated mean to estimate gait 
                    cycle percentage while walking
            */
            switch (command){            
            case 'a':                              
                //Get sensor reading
                inputReading = ain.read();
                wait_ms(20);
                
                //Busy waiting for 1st heel strike
                while (inputReading < 0.20f){
                    device.printf("n|n");//equivalent to printf("n")
                    wait_ms(10);
                    inputReading = ain.read();
                    wait_ms(20);
                }
                t.start();
                t.reset();
                gaitCounter = 0;
                
                //Get the mean of five gait cycles periods
                while (gaitCounter<6){  
                    inputReading = ain.read();
                    //***This "wait" must be minimal***// 
                    wait_ms(20);         
                    
                    //Sensor threshold and time more than 0.8 sec
                    if((inputReading>0.20f)&&(t.read()>0.8f)){
                        gaitCounter++;
                        gaitPeriod[gaitCounter] = t.read_ms();//-startTime;                              
                        t.reset();//reset timer to zero
                        device.printf("g|%d",gaitCounter);
                        wait_ms(10);
                        
                        if (gaitCounter == 5){
                            //mean =(gaitPeriod[2]+gaitPeriod[3]+gaitPeriod[4]+gaitPeriod[5]+gaitPeriod[6])/5.0f;
                            gaitPeriodMean = mean(gaitPeriod,6);
                            //device.printf("Gait period: %1.2f\r\n", mean);
                            device.printf("|%1.2f", gaitPeriodMean);
                            wait_ms(30);
                            gaitCounter = 100;//get out of While
                        }                                                          
                    }
                }
            break;
                        
            case 'b':
                t.stop();
                device.printf("n|b");
                wait_ms(10);
                inputReading = ain.read();
                wait_ms(20);
                
                //get the actuation timing
                //inByte = device.getc();
                //
                //actuationPercentage = atoi(buffer);
                //pc.printf("inByte: ");
                //pc.printf("%d",inByte);
                //pc.printf("\n\r");
                //pc.printf("actuationPercentage: ");
                //pc.printf("%d",actuationPercentage);pc.printf("\n\r");
                
                
                
                //Busy waiting for the first heel strike to occur
                while(inputReading<0.20f){
                    inputReading = ain.read();
                    wait_ms(20);
                    device.printf("n|w");
                    //device.printf("I am in empty While B\r\n");
                }
                    
                //Re-initialize gaitCounter to Zero to start a new cycle
                percentage = 0;
                t.reset();
                t.start();
                
                while(percentage<100.00){
                    //device.printf("I am in the Percentage While\r\n");
                    percentage = t.read_ms()/gaitPeriodMean*100.0f;  
                    device.printf("p|%1.2f|",percentage); 
                    wait_ms(10);
                    
                    //***To Do***
                    //Check if reading the sensor is necessary
                    //to ensure starting a new cycle
                    //Real test to determine
                    
                    //Check if the cycle is finished                        
                    if(percentage >= 100.0){                         
                        //Reset percentage
                        percentage = 0;
                        t.stop();  
                        t.reset();
                        //device.printf("Percentage set to zero,%1.2f\r\n",t.read_ms());  
                        //Start timer for another gait cycle
                        t.start();
                    }
                    
                    if (percentage >= actuationPercentage - 0.2 && percentage <= actuationPercentage + 0.2){
                        ServoActuaute();
                    }
                        
                    //Check if the user wants to stop the system  
                    if (device.readable()){
                        command = device.getc();
                        //Go back to the menu
                        if (command == 'o'){
                            percentage = 100;
                            device.printf("o|%1.2f",percentage);
                            wait_ms(10);
                            t.stop();t.reset();t.start();
                        }
                    }
                }
             break;
        
            default:
                device.printf("Waiting for your commad\r\n");
                wait_ms(10);
            }   
        }
    }
}