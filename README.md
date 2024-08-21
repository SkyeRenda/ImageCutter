# Video Frame Extractor

Video Frame Extractor is a simple C# application that allows users to extract images (frames) from a video at a specified interval. This tool is perfect for those who need to capture still images from video files for analysis, presentation, or creative purposes.

## Features

- **Interval-Based Extraction**: Extract frames at user-defined intervals (e.g., every 1 second, every 30 frames, etc.).
- **Supported Formats**: Works with various video formats (e.g., MP4, AVI, MKV).
- **JPEG Output**: All extracted frames are saved as JPEG images.
- **Automatic Output Directory**: Extracted images are automatically saved in a designated output directory.
- **Easy-to-Use Interface**: Simple and intuitive UI for selecting videos, setting intervals, and exporting frames.
- **Lightweight**: Minimal dependencies and efficient processing.

## Installation

1. Clone this repository:
    ```bash
    git clone https://github.com/yourusername/VideoFrameExtractor.git
    ```

2. Open the solution file in Visual Studio:
    ```bash
    ImageCutter.sln
    ```

3. Restore NuGet packages and build the project.

## Usage

1. **Select Video**: Open the application and load the video file from which you want to extract frames.

2. **Set Interval**: Define the interval at which frames should be extracted. You can specify the interval in seconds or frames.

3. **Extract Frames**: Click the "Start Snipping" button to start the process. The application will process the video and save the frames as JPEG images in the same output directory as the video in a Images folder.

## Requirements

- .NET 8 or higher
- Visual Studio 2019 or later

## Contributing

Contributions are welcome! If you find a bug or have a feature request, please open an issue or submit a pull request.

## Acknowledgements

- [MediaToolkit](https://github.com/AydinAdn/MediaToolkit) - For handling video processing.

## Contact

For questions or feedback, feel free to reach out to [skyerenda@gmail.com](mailto:skyerenda@gmail.com) or create an issue on GitHub.
