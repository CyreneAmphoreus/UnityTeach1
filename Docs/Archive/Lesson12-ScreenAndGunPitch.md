# Lesson12 - Screen 扩展与炮管俯仰

## 教程/小节名称

唐老狮 Unity 教程 - Lesson12 Screen 分 P 扩展练习

## 本节目标

在 Screen 分 P 习题较少的基础上，扩展坦克控制练习：使用鼠标滚轮控制炮管上下俯仰，并在按住鼠标右键时让摄像机围绕坦克观察。

## 已完成内容

- 新增 `Lesson12` 脚本，用于控制炮管 pitch。
- 在 `PlayerController.inputactions` 中新增 `GunPitch` 和 `Aim` 输入。
- 使用鼠标滚轮输入控制炮管上下旋转。
- 使用 `Mathf.Clamp` 限制炮管俯仰角度范围。
- 将 Unity 的 `localEulerAngles.x` 从 `0~360` 转换到 `-180~180` 后再限制角度。
- 在 `Lesson11` 中加入按住右键时摄像机围绕炮塔位置旋转的逻辑。
- 通过 GPT 对话整理了 Clamp、Rotate、EulerAngles、localEulerAngles 的理解过程。

## 做得好的地方

- 能从“Clamp 为什么没效果”追到“Clamp 只是返回值，不会自动修改旋转”的本质。
- 能理解 `Rotate()` 是累加旋转，而限制俯仰角更适合直接设置 `localEulerAngles`。
- 能理解 Unity 欧拉角显示为 `0~360`，并用 `if (x > 180) x -= 360;` 转换为 signed angle。
- 能根据代码审查建议修正 `OnDisable()`、输入解绑、`Mathf.Clamp` 和滚轮灵敏度。

## 当前问题

- `Lesson12.cs` 中保留了学习用注释和旧输入系统对照代码块，适合学习阶段；正式整理时可以进一步精简。
- `finalX` 依赖滚轮事件更新，`Update()` 每帧应用限制值；后续可以尝试把计算和设置集中到输入事件里。
- `Gpt对话协助` 目录属于学习资料，后续可以考虑统一整理到 Docs 体系下。

## 推荐改进方向

- 对滚轮、鼠标移动这类输入，继续区分“事件触发一次”和“每帧持续读取”的差异。
- 摄像机围绕坦克观察时，可以单独设置摄像机旋转速度，避免和炮塔灵敏度强耦合。
- 后续可以学习 `Mathf.DeltaAngle` 或封装角度转换方法。

## 教程写法与当前 Unity 选择

- Screen 相关 API 基础教学用处较少，本项目将练习延伸到更实际的鼠标滚轮和炮管俯仰控制。
- 新 Input System 通过 `.inputactions` 绑定 `<Mouse>/scroll` 和 `<Mouse>/rightButton`，配置更集中。
- 初学阶段手写 `if (x > 180) x -= 360;` 很适合理解 Unity 角度机制。

## 相关提交

- `c63ecfb study: 完成唐老狮教程 - Lesson12 Screen 扩展练习`
- `7793c43 study: 完成唐老狮教程 - Lesson12 场景配置`
