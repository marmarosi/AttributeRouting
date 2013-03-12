namespace AttributeRouting.Framework
{
    /// <summary>
    /// Abstraction used by <see cref="RouteBuilder"/> when generating a url parameter.
    /// </summary>
    /// <remarks>
    /// Due to 
    /// UrlParameter.Optional (used in web-hosted scenarios) and
    /// RouteParameter.Optional (used in self-hosted scenarios).
    /// </remarks>
    public interface IParameterFactory
    {
        /// <summary>
        /// Generates an optional parameter of the correct type.
        /// </summary>
        object Optional();
    }
}
