

public interface ILogicValue
{
    bool Value {get;}
}

public interface IGate
{
    bool Output();
}


public class TrueValue: ILogicValue
{
  public bool Value
  {
    get
    {
        return true;
    }
  }

}

public class FalseValue: ILogicValue
{
  public bool Value
  {
    get
    {
        return false;
    }
  }

}

public class GateOutput : ILogicValue
{
    private IGet gate;

    public GateOutput(IGet gate)
    {
        this.gate = gate;
    }

    public bool Value
    {
        get
        {
            return this.gate.Output();
        }
    }


public class AndGate : IGate
    {
        ILogicValue Input1 {get;}
        ILogicValue Input2 {get;}
        
        ILogicValue bool Output
        {
            get
            {
                
            }

        ;}



    }   



}

