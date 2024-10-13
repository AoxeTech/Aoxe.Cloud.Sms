namespace Aoxe.Azure.Sms;

public class Class1
{
    public async Task Test()
    {
        // Replace <connection_string> with your Azure Communication Services connection string
        var connectionString = "your_connection_string";

        // Initialize the SmsClient
        var smsClient = new SmsClient(connectionString);

        // Prepare the message
        var options = new SmsSendOptions(false);

        // Send the message
        try
        {
            var result = await smsClient.SendAsync(
                "recipient_phone_number_in_e164_format", // Replace with recipient's phone number
                "", // Replace with your message
                "Hello, this is a test SMS message!",
                options,
                CancellationToken.None
            );

            // Output the message ID if successful
            Console.WriteLine($"Sms ID: {result.Value.MessageId}");
        }
        catch (Exception ex)
        {
            // Handle the exception
            Console.WriteLine($"Error sending SMS: {ex.Message}");
        }
    }
}
