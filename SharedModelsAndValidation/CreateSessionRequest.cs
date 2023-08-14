namespace SharedModelsAndValidation
{
    public class CreateSessionRequest
    {
        required public string Password { get; set; }

        required public string Email { get; set; }

    }
}
