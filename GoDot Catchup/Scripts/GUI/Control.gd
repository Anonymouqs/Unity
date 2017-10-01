extends Control

var animator
func _ready():
	animator = get_node("AnimationPlayer")




func _on_begin_pressed():
	print("pressed")
	animator.play("fadeOut")

func begin():
	get_tree().change_scene("res://Scenes/Levels/tutorial.tscn")
	 
