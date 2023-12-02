using Command_Pattern;

class Program
{
    static void Main(string[] args)
    {
        Character character = new Character();
        ICommand Move= new MoveForwards(character);
        ICommand Attack = new AttackCommand(character);
        ICommand Stop = new StoppedMoving(character);

        RemoteControl remote = new RemoteControl();

        
        remote.SetCommand(Move);
        remote.DoAction();
        remote.SetCommand(Attack);
        remote.DoAction();
        remote.UndoAction();
        remote.SetCommand(Stop);
        remote.DoAction();
    }
}
