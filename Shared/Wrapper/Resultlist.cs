using System.Collections.Generic;

namespace RepuestoM.Shared.Wrapper;

public class Resultlist<T>:Result
  {
    public IEnumerable<T> Items { get; set; }= default!;
  
    public new static Resultlist<T> fail()
    {
      return new Resultlist<T>(){Succeeded = false, Message=new List<string>(){"❌"}};
    }
    public new static Resultlist<T> fail(string message)
    {
      return new Resultlist<T>(){Succeeded = false, Message=new List<string>(){"message"}};
      
    }public new static Resultlist<T> fail(List<string> messages)
    {
      return new Resultlist<T>(){Succeeded = false, Message = messages};
      
    }
    public  static Resultlist<T> success(IEnumerable<T> items)
    {
      return new Resultlist<T>(){
        Succeeded = true,
         Message=new List<string>(){"👌🏻"},
         Items= items
        };   
    }
    public  static Resultlist<T> success(IEnumerable<T> items, string message)
    {
      return new Resultlist<T>(){
        Succeeded = true,
         Message=new List<string>(){message},
         Items= items
        };   
    }
     public static Resultlist<T> success(IEnumerable<T> items, List<string> message)
    {
      return new Resultlist<T>(){
        Succeeded = true,
         Message=message,
         Items= items
        };   
    }
    


  }

  

