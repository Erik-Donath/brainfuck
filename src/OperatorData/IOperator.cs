
namespace brainfuck.OperatorData {

    public interface IOperator {

        var data { get; set; }

        override string ToString();
    }

}