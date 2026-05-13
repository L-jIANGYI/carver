namespace Carver.Models
{
    internal class Carver : Vehicle
    {
        public CarverModelType ModelType { get; set; }

        public Carver(CarverModelType modelType) : base("Carver", ToDisplayName(modelType))
        {
            ModelType = modelType;
        }

        public static string ToDisplayName(CarverModelType modelType)
        {
            return modelType switch
            {
                CarverModelType.Base => "Carver Base",
                CarverModelType.RPlus => "Carver R+",
                CarverModelType.Range => "Carver Range",
                CarverModelType.SPlus => "Carver S+",
                CarverModelType.Sport => "Carver Sport",
                _ => modelType.ToString()
            };
        }
    }
}
