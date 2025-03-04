using System;
using System.Collections;
using System.Collections.Generic;
namespace console;

/// <summary>
/// This gets floating numbers between 0 and 1 and if it genrates numbers that are all less thean .5 3 times then it will throw and exception and stop the loop 
/// </summary>
public class IEnum : IEnumerable<float>{
public Random random = new Random();

public IEnumerator<float> GetEnumerator(){
int countBelow =0;
while(true){
  float amount = (float)random.NextDouble();
  yield return amount;

  if(amount<= 0.5){
    countBelow++;
  }else{
    countBelow=0;
  }
  if(countBelow>=3){
    throw new Except("3 numbers in a row were last than .5");
      }
    }
  } 
  IEnumerator IEnumerable.GetEnumerator(){
    return GetEnumerator();
  }
}