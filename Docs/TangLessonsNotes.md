# TangLessonsNotes

这里用于记录唐老狮 Unity 教程中的知识点，并补充当前 Unity 版本下的理解和选择建议。

## 项目当前环境

- Unity 版本：`6000.3.10f1`
- Input System：`1.18.0`
- 教程来源：唐老狮 Unity 教程练习
- 教程时间背景：约 2022 年

## 初始记录：输入系统对照

### 教程写法是否仍然可用

如果教程中使用 `Input.GetAxis`、`Input.GetKey` 等旧输入系统 API，在当前 Unity 中仍然可以用于小型练习和概念学习，尤其适合快速理解键盘、鼠标输入和每帧检测。

### 当前 Unity 版本是否有更推荐的新做法

当前项目已经安装 `com.unity.inputsystem`，因此新项目或需要更清晰输入配置的项目，更推荐使用 Unity Input System，通过 `.inputactions` 文件配置 Action Map、Action 和 Binding。

### 旧写法和新写法的区别

- 旧输入系统：代码直观，上手快，适合早期学习；但输入配置分散在代码和 Project Settings 中，扩展手柄、重绑定和多设备时不够清晰。
- 新 Input System：配置更系统，适合多设备和可维护项目；但概念更多，需要理解 Action Map、Action、Binding、启用/禁用和回调订阅。

### 适合初学阶段的选择建议

初学阶段可以先理解旧输入系统的“每帧读取输入”模型，再逐步切换到新 Input System。学习重点不是立刻追求复杂封装，而是弄清楚输入值从哪里来、什么时候更新、脚本什么时候启用和禁用。

## Lesson11：坦克控制与输入系统对照

### 教程写法是否仍然可用

旧输入系统的 `Input.GetAxis`、`Input.GetAxisRaw`、`Input.GetKey` 等 API 仍然可用于很多练习项目和存量项目。尤其在国内实际项目环境中，仍可能遇到使用旧输入系统的 Unity 项目，因此保留旧输入系统对照版本是有学习价值的。

### 当前 Unity 版本是否有更推荐的新做法

当前项目使用 Unity `6000.3.10f1` 和 Input System `1.18.0`。对于新项目或需要多设备、可重绑定、输入配置可视化的项目，更推荐使用新 Input System，通过 `.inputactions` 管理 Action Map、Action 和 Binding。

### 旧写法和新写法的区别

- 旧输入系统适合快速理解“每帧读取输入值”的流程，代码直观，但大型项目中输入配置容易分散。
- 新 Input System 更适合结构化管理输入，但需要理解 Action Map、Action、Binding、启用/禁用、事件回调等概念。
- `GetAxisRaw` 和 `GetAxis` 不建议随意混用：前者更直接，后者带平滑。若用 `GetAxisRaw` 判断是否有输入，再用 `GetAxis` 取值，可能让平滑输入的尾段被判断截断。

### 坦克控制逻辑

坦克的 `A/D` 更符合直觉的行为是旋转车体，而不是左右平移。较合理的基础控制是：

- `W/S`：沿坦克自身前后方向移动。
- `A/D`：绕 Y 轴旋转坦克车体。
- 鼠标 X：旋转炮塔。

### Inspector 引用与代码查找

`transform.Find("Tank_Head")` 适合初学阶段理解层级查找，但它依赖字符串和层级结构。功能稳定后，更推荐使用：

```csharp
[SerializeField]
private Transform tankHead;
```

然后在 Inspector 中拖拽引用。这样依赖关系更直观，也不容易因为子物体改名导致空引用。

### 适合初学阶段的选择建议

本节可以同时保留新旧输入系统两份脚本，用于对照理解。实际运行时应保证只有一个控制脚本处于启用状态，避免多个脚本实例同时控制同一个坦克。

## Lesson12：Screen 分 P 后的鼠标滚轮与炮管俯仰

### 教程写法是否仍然可用

Screen 相关 API 在基础教学中用处相对少，教程习题较少是合理的。本项目将练习重点延伸到鼠标滚轮、炮管俯仰和摄像机观察控制，这比单纯打印 `Screen.width`、`Screen.height` 更接近实际玩法需求。

### 当前 Unity 版本是否有更推荐的新做法

在当前 Unity 和 Input System 环境下，鼠标滚轮可以通过 `.inputactions` 绑定 `<Mouse>/scroll`。右键按住观察可以绑定 `<Mouse>/rightButton`，并通过 `performed` 和 `canceled` 控制观察状态。

### 旧写法和新写法的区别

- 旧输入系统可用 `Input.GetAxis("Mouse ScrollWheel")` 读取滚轮，适合快速测试。
- 新 Input System 可通过 `GunPitch` Action 读取 `<Mouse>/scroll`，输入配置更集中。
- 滚轮输入通常不是持续轴输入，而是事件式的增量输入。收到输入后处理一次角度变化，会比每帧持续累加更容易控制。

### Clamp 与 Rotate 的区别

`Mathf.Clamp` 只会返回限制后的数值，不会自动修改对象旋转。类似下面的代码没有实际效果：

```csharp
Mathf.Clamp(gun.localEulerAngles.x, -20, 20);
```

必须把返回值赋回变量或 Transform：

```csharp
float x = Mathf.Clamp(value, -20, 20);
gun.localEulerAngles = new Vector3(x, 0, 0);
```

`Rotate()` 是在当前旋转基础上继续累加，适合持续旋转；如果要限制炮管俯仰角，直接设置 `localEulerAngles` 更容易控制上下限。

### Unity 欧拉角范围

Unity 的 `eulerAngles` 和 `localEulerAngles` 通常以 `0~360` 表示角度。负角度会显示成接近 360 的值，例如：

- `-1` 会显示为 `359`
- `-10` 会显示为 `350`
- `-20` 会显示为 `340`

因此，在限制 `-20~20` 这种范围前，需要先把 `0~360` 转换为 `-180~180`：

```csharp
if (x > 180)
{
    x -= 360;
}
```

### 适合初学阶段的选择建议

初学阶段手写 `if (x > 180) x -= 360;` 很适合理解 Unity 角度机制。后续可以再学习 `Mathf.DeltaAngle` 或封装工具方法，让角度处理更简洁。

## Lesson13：Camera 组件、分屏与分层渲染

### 教程写法是否仍然可用

使用多个 Camera、Viewport Rect、Culling Mask、Depth 等方式控制画面显示，在当前 Unity 版本中仍然可用。对于理解摄像机渲染范围、分屏、分层显示非常适合。

### 当前 Unity 版本是否有更推荐的新做法

基础练习中直接配置 Camera 组件是合适的。实际项目中，如果画面需求更复杂，可能会结合 Cinemachine、URP Camera Stack、Render Texture 或自定义渲染流程。但在当前学习阶段，先掌握原生 Camera 组件更重要。

### 旧写法和新写法的区别

- 原生 Camera 配置：适合理解底层概念，操作直接，学习成本低。
- Cinemachine：更适合复杂跟随、镜头切换、阻尼和轨道镜头，但它建立在理解 Camera 基础之上。
- URP Camera Stack：更适合 UI、前景、后处理或多相机叠加需求，但需要渲染管线相关知识。

### Camera Viewport Rect

Viewport Rect 决定摄像机画面渲染到 Game 窗口的哪一块区域：

- `x: 0, width: 0.5` 表示左半屏。
- `x: 0.5, width: 0.5` 表示右半屏。
- `y` 和 `height` 可用于上下分屏。

### Layer 与 Culling Mask

Layer 是对象所属的分组，Culling Mask 是摄像机要渲染哪些 Layer。想让摄像机 A 只看物体 A、摄像机 B 只看物体 B，需要：

- 给物体 A 设置 Layer A。
- 给物体 B 设置 Layer B。
- 摄像机 A 的 Culling Mask 只勾选 Layer A。
- 摄像机 B 的 Culling Mask 只勾选 Layer B。

### Clear Flags 与 Depth

多个摄像机同时渲染到同一个 Game 窗口时，需要注意：

- Depth 越大的摄像机越后渲染。
- Clear Flags 如果清屏，可能覆盖前一个摄像机的画面。
- 如果要叠加多个摄像机画面，需要合理配置 Clear Flags 和 Depth。

### 适合初学阶段的选择建议

当前阶段重点掌握 Camera 自带组件即可。先理解 Viewport Rect、Culling Mask、Depth、Clear Flags，再去学习 Cinemachine 或 URP Camera Stack，会更稳。
