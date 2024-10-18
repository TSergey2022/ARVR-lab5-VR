using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TeleportationEventCatcher : MonoBehaviour
{
    public TeleportationProvider teleportationProvider;

    public XR_Stopwatch stopwatch;

    private void OnEnable()
    {
        // Subscribe to the teleportation events
        teleportationProvider.endLocomotion += OnTeleportationEnd;
    }

    private void OnDisable()
    {
        // Unsubscribe from the teleportation events
        teleportationProvider.endLocomotion -= OnTeleportationEnd;
    }

    private void OnTeleportationEnd(LocomotionSystem locomotionSystem)
    {
        stopwatch.RestartTimer();
        stopwatch.StopTimer();
    }
}
