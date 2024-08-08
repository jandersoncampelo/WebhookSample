namespace Webhook.Server;

record PublishRequest(string Topic, object Message);