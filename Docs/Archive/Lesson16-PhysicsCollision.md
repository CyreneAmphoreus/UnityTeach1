# Lesson16 - 物理系统碰撞检测练习

## 教程/小节名称

唐老狮 Unity 教程 - Lesson16 物理系统碰撞检测练习

## 本节目标

在之前 Input 和 Screen 练习的基础上，加入鼠标左键发射子弹、子弹触地销毁、子弹击中场景中的立方体 3 次后销毁立方体的功能。

## 已完成内容

- 新建 `Assets/Scripts/Lesson16_物理系统碰撞检测/` 练习目录。
- 新建 `Lesson16.unity` 场景。
- 新增 `Lesson16.cs`，通过新 Input System 的 `Fire.performed` 事件在炮口位置实例化子弹。
- 在 `Lesson16.cs` 中保留旧输入系统 `Input.GetButtonDown("Fire1")` 写法作为注释对照。
- 新增 `Bullet.prefab`，配置 `Bullet` Tag、`SphereCollider(Is Trigger)`、`Rigidbody` 和 `BulletController`。
- 新增 `BulletController.cs`，让子弹向前移动，并在触发 `Ground` 或 `Enemy` 时销毁自身。
- 新增 `EnemyController.cs`，敌人被 `Bullet` 触发时扣血，血量归零后销毁自身。
- 新增 `Red.mat` 作为子弹材质。
- 在 `ProjectSettings/TagManager.asset` 中新增 `Ground`、`Enemy`、`Bullet` Tag。
- 将 `ButtleController` / `buttleSpeed` 拼写修正为 `BulletController` / `bulletSpeed`。
- 将敌人的死亡判断从 `Update()` 每帧轮询改为扣血后立即判断。

## 做得好的地方

- 能把输入发射、子弹行为、敌人受击拆到不同脚本中。
- 能根据教程答案和审查建议逐步优化，而不是一次性跳到后面课程的 Rigidbody 运动写法。
- 能明确当前课程重点是 Trigger 碰撞检测、Tag、销毁流程和 Inspector 配置。
- 能提交 TagManager 变更，避免 Tag 在其他环境中丢失。

## 当前问题

- 子弹移动当前仍使用 `Transform.Translate`，符合教程阶段，但不代表完整物理运动写法。
- 当前用 `tag == "xxx"` 进行 Tag 判断，适合小练习；复杂项目中更推荐 `CompareTag()`、Layer 或更明确的伤害接口。
- 子弹速度较快时，离散碰撞检测可能出现穿透，需要后续结合 Rigidbody 碰撞检测模式理解。

## 推荐改进方向

- 后续学习 Rigidbody 运动时，再尝试使用速度、力或 `MovePosition` 控制子弹。
- 后续项目复杂后，可以把敌人受击逻辑抽象为伤害接口或通用 Health 组件。
- 继续观察 `OnTriggerEnter` 和 `OnCollisionEnter` 的触发条件差异。

## 教程写法与当前 Unity 选择

- 使用 Trigger、Tag 和 `Destroy()` 完成基础碰撞练习，在当前 Unity 版本中仍然可用，也适合初学阶段。
- `CompareTag()` 是 Unity 推荐的 Tag 比较方式，通常比直接访问 `tag` 更合适；当前小练习中保留 `tag ==` 也可以帮助直观看懂逻辑。
- 正式项目中，频繁实例化和销毁子弹通常会改为对象池，但这属于后续优化点，不需要在当前小节提前引入。

## 相关提交

- `study: 完成唐老狮教程 - Lesson16 物理系统碰撞检测练习`
