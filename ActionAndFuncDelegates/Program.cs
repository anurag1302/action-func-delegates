namespace ActionAndFuncDelegates
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //Action delegates
            ActionDelegates actionDelegate = new();

            actionDelegate.SimpleActionDelegate();
            actionDelegate.IntDecimalActionDelegate(100, 200.65M);

            //Func delegates
            FuncDelegates funcDelegate = new();

            var result = funcDelegate.SimpleFuncDelegate();
            Console.WriteLine(result);

            var response = funcDelegate.DecimalFuncDelegate(52.25M, 65.45M);
            Console.WriteLine(response);

            //Practical Example
            StudentEligibility studentEligibility = new();
            StudentRepository.GetDistinctionStudents(studentEligibility.StudentFunc);

            Action<int, float> testIntFloatActionDelegate;
            testIntFloatActionDelegate = (int num1, float num2) =>
            {
                var sum = num1 + num2;
                Console.WriteLine($"The sum is {sum}");
            };
            testIntFloatActionDelegate(10, 200.45f);

            Func<float, float, float> testFloatFuncDelegate;
            testFloatFuncDelegate = (float a, float b) =>
            {
                return a / b;
            };
            Console.WriteLine(testFloatFuncDelegate(1000.25f, 24.25f));
        }
    }
}