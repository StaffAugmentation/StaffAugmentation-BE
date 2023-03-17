namespace Shared.Utility;
public class StaffAugmentationException : Exception
{
    private string codeError = string.Empty;
    private string customMessageError = string.Empty;

    /// <summary>
    /// Obtiene o establece el código de error
    /// </summary>
    public string CodeError
    {
        get { return codeError; }
        set { codeError = value; }
    }

    /// <summary>
    /// Obtiene o establece el mensaje
    /// </summary>
    public string CustomMessageError
    {
        get { return customMessageError; }
        set { customMessageError = value; }
    }

    /// <summary>
    /// Lanzar una excepción con mensaje
    /// </summary>
    public StaffAugmentationException()
        : base() { }

    /// <summary>
    /// Lanzar una excepción con mensaje, agregando el código de error
    /// </summary>
    /// <param name="codeError"></param>
    public StaffAugmentationException(string codeError)
        : base() { this.codeError = codeError; }

    /// <summary>
    /// Lanzar una excepción con mensaje, agregando el código de error y un mensaje propio
    /// </summary>
    /// <param name="codeError"></param>
    /// <param name="customMessageError"></param>
    public StaffAugmentationException(string codeError, string customMessageError)
        : base()
    {
        this.codeError = codeError;
        this.customMessageError = customMessageError;
    }

    /// <summary>
    /// Lanzar una excepción con el formato de mensaje y parámetros
    /// uso: throw new CustomException("Exception with parameter value '{0}'", param)
    /// </summary>
    /// <param name="format"></param>
    /// <param name="args"></param>
    public StaffAugmentationException(string format, params object[] args)
        : base(string.Format(format, args)) { }

    /// <summary>
    /// Lanzar una excepción con el mensaje propio, código del error y excepción interna
    /// uso: throw new CustomException(message, innerException)
    /// </summary>
    /// <param name="codeError"></param>
    /// <param name="customMessageError"></param>
    /// <param name="innerException"></param>
    public StaffAugmentationException(string codeError, string customMessageError, Exception innerException)
        : base(customMessageError, innerException)
    {
        this.codeError = codeError;
        this.customMessageError = customMessageError;
    }

    /// <summary>
    /// Lanzar una excepción con formato de mensaje y la excepción interna.
    /// uso: throw new CustomException("Exception with parameter value '{0}'", innerException, param)
    /// </summary>
    /// <param name="format"></param>
    /// <param name="innerException"></param>
    /// <param name="args"></param>
    public StaffAugmentationException(string format, Exception innerException, params object[] args)
        : base(string.Format(format, args), innerException) { }
}