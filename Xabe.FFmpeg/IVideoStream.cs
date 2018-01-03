﻿using System;
using System.IO;
using Xabe.FFmpeg.Enums;

namespace Xabe.FFmpeg
{
    public interface IVideoStream : IStream
    {
        /// <summary>
        ///     Melt watermark into video file
        /// </summary>
        /// <param name="imagePath">Watermark</param>
        /// <param name="position">Position of watermark</param>
        /// <returns>Video stream object</returns>
        IVideoStream SetWatermark(string imagePath, Position position);

        IVideoStream Reverse();

        /// <summary>
        ///     Set size of video
        /// </summary>
        /// <param name="size">VideoSize</param>
        /// <returns>IVideoStream object</returns>
        IVideoStream SetScale(VideoSize size);

        /// <summary>
        ///     Set size of video
        /// </summary>
        /// <param name="size">VideoSize</param>
        /// <returns>IVideoStream object</returns>
        IVideoStream SetSize(VideoSize size);

        /// <summary>
        ///     Set video codec and bitrate
        /// </summary>
        /// <param name="codec">Video codec</param>
        /// <param name="bitrate">Video bitrate</param>
        /// <returns>IVideoStream object</returns>
        IVideoStream SetCodec(VideoCodec codec, int bitrate = 0);

        /// <summary>
        /// Set stream to copy with orginal codec
        /// </summary>
        /// <returns>IVideoStream object</returns>
        IVideoStream CopyStream();

        /// <summary>
        ///     Set filter
        /// </summary>
        /// <param name="filter">Filter</param>
        /// <returns>IVideoStream object</returns>
        IVideoStream SetBitstreamFilter(BitstreamFilter filter);

        /// <summary>
        ///     Duration
        /// </summary>
        TimeSpan Duration { get; }

        /// <summary>
        ///     Width
        /// </summary>
        int Width { get; }

        /// <summary>
        ///     Height
        /// </summary>
        int Height { get; }

        /// <summary>
        ///     Frame rate
        /// </summary>
        double FrameRate { get; }

        /// <summary>
        ///     Screen ratio
        /// </summary>
        string Ratio { get; }
    }
}
