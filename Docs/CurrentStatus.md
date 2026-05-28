# CurrentStatus

## 当前学习状态

- 当前完成：Lesson14 坐标转换练习
- 下一阶段：继续学习 Lesson15 或下一 P 内容
- 学习来源：唐老狮 Unity 教程练习
- Unity 版本：`6000.3.10f1`
- Input System：`1.18.0`
- 当前分支：`master`
- 远程仓库：`https://github.com/CyreneAmphoreus/UnityTeach1.git`

## 最近完成

- Lesson11：新旧输入系统对照、坦克移动、车体旋转、炮塔旋转。
- Lesson12：Screen 分 P 扩展练习、鼠标滚轮控制炮管俯仰、右键摄像机观察。
- Lesson13：Camera 分屏、跟随目标、Layer + Culling Mask 分层渲染。
- Lesson14：`WorldToScreenPoint`、`ScreenToWorldPoint`、鼠标点击位置创建 Cube。

## 当前重点概念

- 新旧输入系统都需要认识：新项目更推荐 Input System，存量项目仍可能使用旧输入系统。
- Inspector 显式引用通常比运行时字符串查找更稳定。
- `Mathf.Clamp` 只返回限制后的值，不会自动修改 Transform。
- Unity 欧拉角常以 `0~360` 表示，限制负角度前需要转换成 signed angle。
- Camera 的 Viewport Rect 可用于分屏。
- Layer + Culling Mask 可让不同摄像机看到不同对象。
- `ScreenToWorldPoint` 必须提供有意义的 `z` 深度。
- 鼠标点击场景放置物体时，实际项目中常用射线检测。

## 当前常见风险

- 多个脚本实例同时启用，导致重复执行生命周期或控制同一对象。
- Inspector 引用未绑定导致空引用。
- 修改 Layer/Tag/Input Actions 后忘记提交 `ProjectSettings` 或生成代码。
- Unity 场景文件中的临时摄像机位置、Transform 变化混入提交。
- 文档收尾时遗漏 README 或 CurrentStatus。

## 默认检查流程

后续轻量检查时，优先读取：

- `Docs/CurrentStatus.md`
- `README.md`
- 当前 Lesson 的脚本和场景
- `git status`
- 当前变更的 `git diff`

只有在需要复盘历史时，才读取 `Docs/Archive/` 中对应 Lesson 文件。

## 最近提交

- `f705624 study: 完成唐老狮教程 - Lesson14 坐标转换练习`
