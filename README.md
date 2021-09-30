# Unity-VisionLib-echo3D-demo-Image-Tracking
Demo that image tracks 3D Models with Unity, VisionLib, and echo3D.

## Register
Don't have an API key? Make sure to register for FREE at [echo3D](https://console.echo3D.co/#/auth/register).

## Setup
* Download and install the [VisionLib SDK](https://visionlib.com/) in a new Unity project.
* Follow the instructions on our [doumention page](https://docs.echo3D.co/unity/adding-ar-capabilities) to [set your API key](https://docs.echo3D.co/unity/adding-ar-capabilities#3-set-you-api-key).
* Add the apartment model to the console setting the [clouds image](https://docs.echo3D.co/quickstart/add-a-3d-model) from the [assets](./assets) folder.
* Overwrite the existing _echo3D/CustomBehavior.cs script with the new [CustomBehavior](./CustomBehavior.cs) file.
* Set up a Poster Tracking scene using [VisionLib](https://visionlib.com/documentation/vl_unity_s_d_k_poster_tracker_tutorial/)'s instructions, using posterTrackingSample.vl and ScriptTest.cs in the Scripts folder instead of TutorialPosterTracker.vl and Tutorial.cs.
* Tag the VLCamera Object as MainCamera in your scene.


## Run
* [Build and run the AR application](https://docs.echo3D.co/unity/adding-ar-capabilities#4-build-and-run-the-ar-application).


## Learn more
Refer to our [documentation](https://docs.echo3D.co/unity/) to learn more about how to use Unity, AR Foundation, and echo3D.

## Support
Feel free to reach out at [support@echo3D.co](mailto:support@echo3D.co) or join our [support channel on Slack](https://go.echo3D.co/join). 

## Screenshots
![screenshot1](/Screenshots/Screenshot.gif)
![ScreenShot2](/Screenshots/EchoAR_Console.png)
