using System.Numerics;

PhysicsObject obj = new PhysicsObject(Vector2.Zero, Vector2.Zero, new Vector2(1, 0));

double deltaTime = Convert.ToDouble(Console.ReadLine());

for (double i = 0; i < 5; i += deltaTime)
{
	Console.WriteLine("t = " + (i + 1));

	if (i > 2)
		obj.Acceleration.X = -1;

	obj.Integerate(deltaTime);
}
