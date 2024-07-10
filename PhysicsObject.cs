using System.Numerics;

public class PhysicsObject
{
	public Vector2 Position;
	public Vector2 Velocity;
	public Vector2 Acceleration;

	public PhysicsObject(Vector2 position, Vector2 velocity, Vector2 acceleration)
	{
		this.Position = position;
		this.Velocity = velocity;
		this.Acceleration = acceleration;
	}

	public void Integerate(double deltaTime)
	{
		Vector2 newVel, newPos, newAcc;
		newAcc = this.Acceleration;
		newVel = this.Velocity + (0.5f * (newAcc + this.Acceleration) * (float)deltaTime);
		newPos = this.Position + (0.5f * (newVel + Velocity) * (float)deltaTime);

		this.Velocity = newVel;
		this.Position = newPos;

		this.printInfo();
	}

	private void printInfo()
	{
		Console.WriteLine("DIS: " + this.Position);
		Console.WriteLine("VEL: " + this.Velocity);
		Console.WriteLine("ACC: " + this.Acceleration);
		Console.WriteLine();
	}
}
