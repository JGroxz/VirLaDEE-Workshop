using System.Collections.Generic;
using System.Net;
using Mirage.Discovery;
using UnityEngine;

public class BallGameDiscovery : LanDiscoveryBase<DiscoveryRequest, DiscoveryResponse>
{
    protected override DiscoveryResponse ProcessClientRequest(DiscoveryRequest request, IPEndPoint endpoint)
    {
        Debug.Log($"Received request from {endpoint.Address}.");
        
        return new DiscoveryResponse()
        {
            
        };
    }

    protected override DiscoveryRequest CraftDiscoveryRequest()
    {
        Debug.Log("Crafting discovery request...");
        
        return new DiscoveryRequest()
        {
            
        };
    }

    protected override void ProcessServerResponse(DiscoveryResponse response, IPEndPoint endpoint)
    {
        Debug.Log($"Discovered server at {endpoint.Address}!");
    }
}

public struct DiscoveryRequest
{
    
}

public struct DiscoveryResponse
{
    
}
