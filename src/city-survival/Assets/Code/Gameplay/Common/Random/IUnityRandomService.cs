namespace Code.Gameplay.Common.Random
{
    public interface IUnityRandomService
    {
        float Range(float inclusiveMin, float inclusiveMax);
        int Range(int inclusiveMin, int exclusiveMax);
    }
}