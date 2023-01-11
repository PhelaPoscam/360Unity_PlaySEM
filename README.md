# Unity 360 Video Player compatible with SEMRenderer





# Download 360 without errors
youtube-dl --format "bestvideo[height<=2160]+bestaudio[ext=m4a]/mp4" --user-agent "" "https://www.youtube.com/watch?v=XOMKD8kGpfw&t=80s"

# Download 180 without errors
yt-dlp --format "bestvideo[height<=2160]+bestaudio[ext=m4a]/mp4" --user-agent "" "https://www.youtube.com/watch?v=XOMKD8kGpfw&t=80s" --merge-output-format mp4

# Stereo para Mono

ffmpeg -i Kungfuscius.mp4 -vf stereo3d=tbl:ml -metadata:s:v:0 stereo_mode="mono"  KungfusciusCorrected.mp4

# Convert to Mp4
ffmpeg -i fireworksCorrected.mkv -c:v copy -c:a copy fireworksCorrected.mp4

# Method 2
ffmpeg -i fireworksCorrected.mkv -codec copy fireworksCorrected.mp4

# Cut videeo
ffmpeg -i fireworksCorrected.mp4 -ss 00:00:01 -to 00:01:00 -c:v copy -c:a copy fireworksCorrected_1min.mp4

ffmpeg -ss 00:01:00 -i fireworksCorrected.mp4 -t 00:02:00 -c copy fireworksCorrected_1to2min.mp4

# Hastened
ffmpeg -i "fireworksCorrected.mp4" -itsoffset -5 -i "fireworksCorrected.mp4" -map 0:v -map 1:a -c copy "fireworksCorrected_hastened.mp4"

# Delayed
ffmpeg -i "fireworksCorrected.mp4" -itsoffset -5 -i "fireworksCorrected.mp4" -map 1:v -map 0:a -c copy "fireworksCorrected_delayed.mp4"

