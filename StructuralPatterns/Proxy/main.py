from GameDisplay import ProxyGameDisplay, RealGameDisplay

proxyGameDisplay = ProxyGameDisplay(RealGameDisplay())

proxyGameDisplay.play()