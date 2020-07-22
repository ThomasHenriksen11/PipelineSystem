namespace PipelineSystem.Application_Layer
{
    public interface ICrud
    {
        void Add(string name);
        string Retrieve(string name);
        void Update();

    }
}
