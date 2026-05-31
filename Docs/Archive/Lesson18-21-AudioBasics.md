# Lesson18-21 - Audio 基础理论

## 教程/小节名称

唐老狮 Unity 教程 - Lesson18 到 Lesson21 Audio 基础理论

## 本节目标

理解 Unity 音频从资源导入、场景播放、代码控制到麦克风录制和采样数据读取的基础流程。

## 已完成内容

- Lesson18：学习 AudioClip 音频文件导入参数。
- Lesson19：学习 `AudioSource` 和 `AudioListener` 两个组件的参数。
- Lesson20：学习 `AudioSource` 组件的常用 API。
- Lesson21：学习麦克风开始录制、结束录制、播放录制的音频，以及用 `AudioClip.GetData()` 获取音频采样数据。

## Lesson18 - AudioClip 导入参数

### 主要参数

- `Force To Mono`：将多声道音频合并为单声道，适合不需要立体声的音效，可节省资源。
- `Normalize`：合并单声道后对音量进行归一化。
- `Load In Background`：后台加载较大音频，减少主线程卡顿。
- `Ambisonic`：空间音频/全景声相关，普通 BGM 和音效通常不用。
- `Load Type`：决定音频如何加载和解压。
- `Preload Audio Data`：场景加载时预加载音频数据。
- `Compression Format`：决定压缩格式。
- `Quality`：压缩质量，越高音质越好、体积越大。
- `Sample Rate Setting`：采样率设置。

### Load Type 理解

- `Decompress On Load`：加载时解压，占用内存较多，但播放开销低，适合短音效。
- `Compressed In Memory`：内存中保持压缩，播放时解码，适合中等长度音频。
- `Streaming`：边读边播，适合较长 BGM。

### Compression Format 理解

- `PCM`：不压缩，质量高但体积大，适合很短且频繁播放的音效。
- `ADPCM`：折中格式，适合部分短音效。
- `Vorbis`：压缩率高，常用于 BGM 或较长音频。

## Lesson19 - AudioSource 和 AudioListener

### AudioSource

`AudioSource` 负责播放声音，通常挂在会发出声音的物体上。

常见参数：

- `AudioClip`：要播放的音频资源。
- `Output`：输出到 Audio Mixer，后续可用于音量分组和效果处理。
- `Mute`：静音音源。
- `Play On Awake`：物体启用时自动播放。
- `Loop`：循环播放，常用于 BGM 或环境音。
- `Priority`：声音播放优先级。
- `Volume`：音量。
- `Pitch`：音调和播放速度。
- `Stereo Pan`：左右声道平衡。
- `Spatial Blend`：2D 与 3D 声音混合，`0` 为 2D，`1` 为 3D。
- `3D Sound Settings`：3D 声音的距离衰减、扩散等设置。

### AudioListener

`AudioListener` 负责接收声音，通常挂在 Main Camera 上。

重点：

- 一个场景通常只保留一个启用的 `AudioListener`。
- 多个启用的 `AudioListener` 会导致 Unity 报警。
- 3D 声音效果取决于 `AudioSource` 和 `AudioListener` 的相对位置。

## Lesson20 - AudioSource 常用 API

常用 API：

- `Play()`：播放当前 `AudioClip`。
- `Pause()`：暂停播放。
- `UnPause()`：从暂停处继续播放。
- `Stop()`：停止播放，再次 `Play()` 会从头开始。
- `PlayOneShot(clip)`：播放一次指定音效，不打断当前 clip，适合按钮音、攻击音效、碰撞音效。
- `isPlaying`：判断是否正在播放。
- `clip`：读取或切换当前绑定的音频资源。
- `volume`：控制音量。
- `pitch`：控制音调和播放速度。
- `loop`：控制是否循环。
- `time` / `timeSamples`：读取或设置播放进度。
- `mute`：静音。

初学阶段重点：

- `Play()` 适合 BGM、循环音或固定音源。
- `PlayOneShot()` 适合频繁触发的短音效。
- `Stop()` 适合明确中断声音并从头重新播放的场景。

## Lesson21 - 麦克风录制和 AudioClip 数据

常用 API：

- `Microphone.devices`：获取可用麦克风设备列表。
- `Microphone.Start(...)`：开始录制，返回一个 `AudioClip`。
- `Microphone.End(deviceName)`：结束指定设备的录制。
- `Microphone.IsRecording(deviceName)`：判断是否正在录制。
- `Microphone.GetPosition(deviceName)`：获取当前录制位置。
- `AudioClip.GetData(float[] data, int offsetSamples)`：读取音频采样数据。

重点理解：

- 麦克风录制得到的是 `AudioClip`，可以赋给 `AudioSource.clip` 后播放。
- `AudioClip.GetData()` 获取的是原始采样数据。
- 获取采样数据不等于已经保存成音频文件；如果要保存 WAV 等格式，还需要额外编码和写文件逻辑。

## 做得好的地方

- 能把没有练习题的音频小节当作理论基础记录下来，而不是忽略。
- 能理解音频系统不只是播放声音，还包括资源导入、加载策略、组件参数、代码控制和录音数据。
- 能在后续项目开始前补齐 UGUI 和 PlayerPrefs，避免 UI 与存档能力不足影响整合项目。

## 当前问题

- Audio 理论还没有通过完整项目功能验证。
- 录音保存到实际音频文件还没有实现，只学习了采样数据读取入口。

## 推荐改进方向

- 后续项目中加入 BGM、按钮音效、开火音效、受击音效来巩固 AudioSource。
- 使用 PlayerPrefs 保存音量设置。
- 后续如果需要录音功能，再进一步学习 WAV 编码和文件写入。

## 教程写法与当前 Unity 选择

- AudioClip Import Settings、AudioSource、AudioListener、Microphone、AudioClip.GetData 在当前 Unity 版本中仍然可用。
- 初学阶段先掌握 Unity 内置音频流程即可，不需要提前引入复杂音频中间件。

## 相关提交

- `study: 更新唐老狮教程练习记录 - Audio理论与阶段暂停`
