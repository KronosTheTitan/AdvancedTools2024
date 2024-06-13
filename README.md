<h1>Research Question</h1>
What difference can be found between the usage of a floor marked static when compared to a floor that isn't marked as static in a scenario with a large number of rigid bodies with simultaneous collisions.

<h1>Hypothesis</h1>
Due to the large number of collisions the impact will be relatively limited.

<h1>Methodology</h1>
The test will consist of individual measurements of 2500 frames in which 10000 in a 100 x 100 square grid are continuously bouncing with a bounciness value of 0.5.
The variables measured will be the frame time in milliseconds (Time.DeltaTime * 1000) and whether the floor is marked as static.<br>

Potential external effects that can influence the measurements include
 - The operating system scheduler
 - Background processes
 - System thermals and the resulting boost or throttling

In order to minimize these effects of these uncontrollable variables 5 runs of each version will be done.

<h1>Results</h1>
The raw data gathered can be found in the Data.xlsx sheet.

<h1>Analysis</h1>
Due to the rather unstable and outlying values found in the first ten frames are not considered for further analysis.

Averages
Number of spikes per run (average * 1.1 or greater)