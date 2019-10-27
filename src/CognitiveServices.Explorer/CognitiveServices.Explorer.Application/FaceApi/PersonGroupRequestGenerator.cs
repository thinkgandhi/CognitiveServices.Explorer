﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace CognitiveServices.Explorer.Application.FaceApi
{
    public static class PersonGroupRequestGenerator
    {
        public static HttpRequest Create(string groupId, string name, string? userData = null, string? recognitionModel = null)
        {
            return new HttpRequest
            {
                HttpMethod = "POST",
                ContentType = "application/json",
                RelativePath = $"face/v1.0/persongroups/{groupId}",
                Body = JsonConvert.SerializeObject(new
                {
                    name,
                    recognitionModel,
                    userData
                }),
                Cost = ServiceCost.FaceApiTransation(1),
                CognitiveServiceDoc = "https://westus.dev.cognitive.microsoft.com/docs/services/563879b61984550e40cbbe8d/operations/563879b61984550f30395244"
            };
        }

        public static HttpRequest Update(string groupId, string name, string? userData = null)
        {
            return new HttpRequest
            {
                HttpMethod = "PATCH",
                ContentType = "application/json",
                RelativePath = $"face/v1.0/persongroups/{groupId}",
                Body = JsonConvert.SerializeObject(new
                {
                    name,
                    userData
                }),
                Cost = ServiceCost.FaceApiTransation(1),
                CognitiveServiceDoc = "https://westus.dev.cognitive.microsoft.com/docs/services/563879b61984550e40cbbe8d/operations/563879b61984550f3039524a"
            };
        }

        public static HttpRequest List()
        {
            return new HttpRequest
            {
                HttpMethod = "GET",
                RelativePath = $"face/v1.0/persongroups",
                Queries = new Dictionary<string, string>
                {
                    { "returnRecognitionModel", "true" }
                },
                Cost = ServiceCost.FaceApiTransation(1),
                CognitiveServiceDoc = "https://westus.dev.cognitive.microsoft.com/docs/services/563879b61984550e40cbbe8d/operations/563879b61984550f30395248"
            };
        }

        public static HttpRequest Delete(string groupId)
        {
            return new HttpRequest
            {
                HttpMethod = "DELETE",
                RelativePath = $"face/v1.0/persongroups/{groupId}",
                Cost = ServiceCost.FaceApiTransation(1),
                CognitiveServiceDoc = "https://westus.dev.cognitive.microsoft.com/docs/services/563879b61984550e40cbbe8d/operations/563879b61984550f30395245"
            };
        }

        public static HttpRequest Train(string groupId)
        {
            return new HttpRequest
            {
                HttpMethod = "POST",
                RelativePath = $"face/v1.0/persongroups/{groupId}/train",
                Cost = ServiceCost.FaceApiTransation(1),
                CognitiveServiceDoc = "https://westus.dev.cognitive.microsoft.com/docs/services/563879b61984550e40cbbe8d/operations/563879b61984550f30395249"
            };
        }

        public static HttpRequest CheckTraining(string groupId)
        {
            return new HttpRequest
            {
                HttpMethod = "GET",
                RelativePath = $"face/v1.0/persongroups/{groupId}/training",
                Cost = ServiceCost.FaceApiTransation(1),
                CognitiveServiceDoc = "https://westus.dev.cognitive.microsoft.com/docs/services/563879b61984550e40cbbe8d/operations/563879b61984550f30395247"
            };
        }
    }
}
