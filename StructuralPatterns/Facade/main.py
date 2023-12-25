from VedioRoomFacade import VideoRoomFacade

superRemote = VideoRoomFacade()

superRemote.show_all_status()

#Play KTV
superRemote.read_ktv()
superRemote.select_song("Moon")
superRemote.play_song()
superRemote.show_all_status()