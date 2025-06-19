<!-- Improved compatibility of back to top link: See: https://github.com/othneildrew/Best-README-Template/pull/73 -->
<a id="readme-top"></a>

<!-- PROJECT SHIELDS -->
[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT][license-shield]][license-url]
[![Discord][discord-shield]][discord-url]

<!-- PROJECT LOGO -->
<br />
<div align="center">
  <a href="https://github.com/ExperiencesXP/unity-shader-tweak">

  <h3 align="center">Unity Shader Tweak</h3>

  <p align="center">
    Easily reassign shaders to multiple Unity materials at once
    <br />
    <a href="https://github.com/ExperiencesXP/unity-shader-tweak"><strong>Explore the docs »</strong></a>
    <br />
    <br />
    <a href="https://github.com/ExperiencesXP/unity-shader-tweak/releases">View Releases</a>
    ·
    <a href="https://github.com/ExperiencesXP/unity-shader-tweak/issues/new?labels=bug&template=bug-report---.md">Report Bug</a>
    ·
    <a href="https://github.com/ExperiencesXP/unity-shader-tweak/issues/new?labels=enhancement&template=feature-request---.md">Request Feature</a>
  </p>
</div>

<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li><a href="#about-the-project">About The Project</a></li>
    <li><a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#roadmap">Roadmap</a></li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
    <li><a href="#acknowledgments">Acknowledgments</a></li>
  </ol>
</details>

<!-- ABOUT THE PROJECT -->
## About The Project

![Unity 2019.4.31f1](https://img.shields.io/badge/Unity-2019.4.31f1-green?logo=unity)
![Unity 2022.3.22f1](https://img.shields.io/badge/Unity-2022.3.22f1-green?logo=unity)

Unity Shader Tweak is a tool that streamlines the process of fixing broken shaders across multiple materials in Unity. This is especially useful for VRChat avatars, where materials may sometimes reference `Hidden/InternalErrorShader` instead of your intended shader.

With this tool, you can:
- Quickly identify affected materials
- Select a shader and reassign it to multiple materials at once
- Access the tool through the Unity Editor's context menu

No more manual reassignment — tweak once, apply everywhere.

**Supported Unity Versions:** Tested on Unity 2019.4.31f1 and 2022.3.22f1. Should work on other versions, let me know.

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- GETTING STARTED -->
## Getting Started

### Prerequisites

Make sure you have the correct Unity Version installed:

### Installation

#### Method 1: Unity Package Manager (UPM)

You can install this tool using Unity's Package Manager by adding a **Git URL**:

1. Open Unity
2. Go to `Window > Package Manager`
3. Click the `+` button (Top left) > `Add package from git URL...`
4. Paste the following: `https://github.com/ExperiencesXP/unity-shader-tweak.git?path=/com.experiencesxp.shadertweak`

#### Method 2: Manual `.unitypackage` (via Releases)

1. Go to the [Releases page](https://github.com/ExperiencesXP/unity-shader-tweak/releases)
2. Download the latest `.unitypackage`
3. In Unity, go to `Assets > Import Package > Custom Package...`
4. Choose the `.unitypackage` file and import it

> Step 3-4 can be skipped by simply dragging the package straight into your Assets

Use this method if you prefer traditional imports or are not using UPM.


<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- USAGE EXAMPLES -->
## Usage

1. In the Unity Editor, select multiple materials in the Project window.
2. Right-click and choose `Tweak Shader on Materials...` from the context menu.
3. Select your desired shader.
4. Click to apply it to all selected materials.

Ideal for fixing VRChat avatars or imported assets with broken shader references.

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- ROADMAP -->
## Roadmap

- [ ] Automatically find and fix broken shaders

See the [open issues](https://github.com/ExperiencesXP/unity-shader-tweak/issues) for more ideas and feedback.

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- CONTRIBUTING -->
## Contributing

Contributions are welcome! If you have suggestions or improvements:

1. Fork the repo
2. Create a new branch (`git checkout -b feature/YourFeatureName`)
3. Commit your changes (`git commit -m 'Add YourFeatureName'`)
4. Push to GitHub (`git push origin feature/YourFeatureName`)
5. Open a pull request

<p align="right">(<a href="#readme-top">back to top</a>)</p>

### Top Contributors

<a href="https://github.com/ExperiencesXP/unity-shader-tweak/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=ExperiencesXP/unity-shader-tweak" />
</a>

<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE.txt` for details.

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- CONTACT -->
## Contact

ExperiencesXP - [discord](https://discord.com/users/558762972684484622) - [email](mailto:gitexperiences@gmail.com)

Project Link: [https://github.com/ExperiencesXP/unity-shader-tweak](https://github.com/ExperiencesXP/unity-shader-tweak)

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- ACKNOWLEDGMENTS -->
## Acknowledgments

* [Unity](https://unity.com/)
* [Contrib.rocks](https://contrib.rocks)

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- MARKDOWN LINKS & IMAGES -->
[contributors-shield]: https://img.shields.io/github/contributors/ExperiencesXP/unity-shader-tweak.svg?style=for-the-badge
[contributors-url]: https://github.com/ExperiencesXP/unity-shader-tweak/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/ExperiencesXP/unity-shader-tweak.svg?style=for-the-badge
[forks-url]: https://github.com/ExperiencesXP/unity-shader-tweak/network/members
[stars-shield]: https://img.shields.io/github/stars/ExperiencesXP/unity-shader-tweak.svg?style=for-the-badge
[stars-url]: https://github.com/ExperiencesXP/unity-shader-tweak/stargazers
[issues-shield]: https://img.shields.io/github/issues/ExperiencesXP/unity-shader-tweak.svg?style=for-the-badge
[issues-url]: https://github.com/ExperiencesXP/unity-shader-tweak/issues
[license-shield]: https://img.shields.io/github/license/ExperiencesXP/unity-shader-tweak.svg?style=for-the-badge
[license-url]: https://github.com/ExperiencesXP/unity-shader-tweak/blob/main/LICENSE.txt
[discord-shield]: https://img.shields.io/badge/Discord-5865F2?style=for-the-badge&logo=discord&logoColor=white
[discord-url]: https://discord.com/users/558762972684484622
[product-screenshot]: images/screenshot.png
