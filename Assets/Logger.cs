using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

internal struct Measurement
{
    public int frame;
    public float frameTimeInMilliSeconds;
    public int collisionsDuringFrame;
}

public class Logger : MonoBehaviour
{
    [SerializeField] private int testLengthInFrames = 10000;
    [SerializeField] private Slider progressBar;
    private List<Measurement> _measurements;
    private int _frame;
    private int _collisions;
    
    private void Start()
    {
        _measurements = new List<Measurement>();
        _frame = 0;

        progressBar.value = _frame;
        progressBar.maxValue = testLengthInFrames;
    }

    private void Update()
    {
        Measurement measurement = new Measurement();

        /*
        The multiplication by 1000 is need to convert the delta time in seconds that unity provides into milliseconds
        otherwise an inconsistent measurement would exist as frame times are usually displayed in milliseconds.
        */
        measurement.frame = _frame;
        measurement.frameTimeInMilliSeconds = Time.deltaTime * 1000;
        measurement.collisionsDuringFrame = _collisions;
        
        _frame++;
        _collisions = 0;
        
        progressBar.value = _frame;
        
        _measurements.Add(measurement);

        if (_frame <= testLengthInFrames) return;
        Export();
        Application.Quit();
    }

    private void Export()
    {
        List<string> lines = new List<string>();

        foreach (Measurement measurement in _measurements)
        {
            string line = measurement.frame + "," + measurement.frameTimeInMilliSeconds + "," + measurement.collisionsDuringFrame;
            lines.Add(line);
        }
        
        File.WriteAllLines("F:/03 School/results.csv",lines);
    }

    public void AddCollision()
    {
        _collisions++;
    }
}
