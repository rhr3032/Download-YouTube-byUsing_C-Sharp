using System.IO;
using VideoLibrary; /*install VideoLibrary*/

string url = @"yourUrl"
string pathDownload = @"E:\";

YouTube youtube = YouTube.Default;
YouTubeVideo video = youtube.GetVideo(url);
File.WriteByBytes(pathDownload + video.FullName, video.GetBytes());
