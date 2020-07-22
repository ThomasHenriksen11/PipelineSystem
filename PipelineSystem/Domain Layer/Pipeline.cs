namespace PipelineSystem.Domain_Layer
{
    public class Pipeline
    {
        public string PipelineName { get; set; }

        public override string ToString()
        {
            return PipelineName;
        }

    }
}
