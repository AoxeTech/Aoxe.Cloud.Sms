namespace Aoxe.Aws.Sms;

public class Class1
{
    public async Task Test()
    {
        // 你可以从环境变量、配置文件或其他来源获取凭据和区域
        string accessKey = "your-access-key-id";
        string secretKey = "your-secret-access-key";
        string region = "your-region"; // 例如 "us-west-2"

        // 初始化 SNS 客户端
        var client = new AmazonSimpleNotificationServiceClient(accessKey, secretKey, region);

        // 构造 SMS 消息
        var publishRequest = new PublishRequest
        {
            TopicArn = "your-sns-topic-arn", // 替换为你的 SNS 主题 ARN
            Message = "Hello, this is a test SMS message!",
            PhoneNumber = "+12345678901" // 替换为接收者的电话号码，确保包含国际区号
            // 如果你想使用模板，可以添加 TemplateId 和 TemplateData 属性
        };

        try
        {
            // 发送消息
            var publishResponse = await client.PublishAsync(publishRequest);

            // 输出响应消息 ID（如果需要）
            Console.WriteLine("Message ID: " + publishResponse.MessageId);
        }
        catch (Exception ex)
        {
            // 处理异常
            Console.WriteLine("Error sending SMS: " + ex.Message);
        }
    }
}
