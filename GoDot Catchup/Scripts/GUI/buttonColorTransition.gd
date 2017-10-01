extends TextureButton

var player 

func _ready():
	player = get_node("AnimationPlayer")


func _on_Button_mouse_enter():
	print(player.is_playing())
	if player.is_playing():
		player.set_speed(1)
		return null
	player.play("buttonFade")


func _on_Button_mouse_exit():
	if player.is_playing():
		player.set_speed(-1)
		return null
	player.play_backwards("buttonFade")
