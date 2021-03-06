using Mirror;
using UnityEngine;

public class MyNetworkPlayer : NetworkBehaviour
{
    [SyncVar] [SerializeField] private string displayName = "Missing Name";
    [SyncVar] [SerializeField] private Color displayColor = Color.blue;

    [Server]
    public void SetDisplayName(string newDisplayName)
    {
        displayName = newDisplayName;
    }

    [Server]
    public void SetColor(Color newColor)
    {
        displayColor = newColor;
    }

}