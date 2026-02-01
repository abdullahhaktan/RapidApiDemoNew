namespace RapidApiDemoNew.GeminiDtos
{
    // Main request DTO for Gemini AI API calls
    public class GeminiRequestDto
    {
        public List<Content> contents { get; set; } // Conversation history/messages
        public GenerationConfig? generationConfig { get; set; } // Optional response settings
    }

    // Represents a message in the conversation (user/assistant/system)
    public class Content
    {
        public string role { get; set; } // "user", "assistant", or "system"
        public List<Part> parts { get; set; } // Message content parts
    }

    // Individual content part (typically text, but could be other media types)
    public class Part
    {
        public string text { get; set; } // Text content of the message part
    }

    // Configuration for controlling AI response generation
    public class GenerationConfig
    {
        public float? temperature { get; set; } // Creativity control (0.0-1.0)
        public int? maxOutputTokens { get; set; } // Maximum response length limit
    }
}