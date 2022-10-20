using InputUtilitys;
namespace Ex29_27_19_Takahashi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float variable;
            float variable1;
            float variable2;

            //円柱の数値を入力
            variable = InputUtility.InputFloat("円の半径");
            variable1 = InputUtility.InputFloat("円柱の高さ");
            //円柱の表面積と体積を出力
            Console.WriteLine($"円柱の表面積={Cylinder.GetSurface(variable,variable1)}\n円柱の体積={Cylinder.GetVlueme(variable, variable1)}");

            //球
            variable = InputUtility.InputFloat("球の半径");
            Console.WriteLine($"球の表面積={Sphere.GetSurface(variable)}\n球の体積={Sphere.GetVlueme(variable)}");

            //三角柱
            variable = InputUtility.InputFloat("底辺");
            variable1 = InputUtility.InputFloat("三角形の高さ");
            variable2 = InputUtility.InputFloat("高さ");
            Console.WriteLine($"三角柱の表面積={TriangularPrism.GetSurface(variable,variable1,variable2)}\n三角柱の体積={TriangularPrism.GetVlueme(variable, variable1, variable2)}");
        }
    }

    static class Cylinder
    {
        public static float GetSurface(float radius, float height)
        {
            return radius * radius * (float)Math.PI * 2 + radius * 2 * (float)Math.PI * height;
        }

        public static float GetVlueme(float radius, float height)
        {
            return radius * radius * (float)Math.PI * height;
        }
    }

    static class Sphere
    {
        public static float GetSurface(float radius)
        {
            return radius * radius * (float)Math.PI * 4;
        }

        public static float GetVlueme(float radius)
        {
            return 4.0f / 3.0f  * (float)Math.PI * radius * radius * radius;
        }
    }

    static class TriangularPrism
    {
        public static float GetSurface(float bottom, float triangleHeigth,float height)
        {
            return bottom * triangleHeigth + (bottom + triangleHeigth + (float)Math.Sqrt(bottom * bottom + triangleHeigth * triangleHeigth)) * height;
        }

        public static float GetVlueme(float bottom, float triangleHeigth, float height)
        {
            return bottom * triangleHeigth / 2 * height;
        }
    }
}

