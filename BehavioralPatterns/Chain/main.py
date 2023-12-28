from Handler import GeneralManager, MajorDemo, CommonManager
from Request import ApplyRequest

pm = CommonManager("PM")
gl = MajorDemo("GL")
gm = GeneralManager("GM")

# 設定上級
pm.set_superior(gl)
gl.set_superior(gm)

# 請假
request = ApplyRequest()
request.requestType = "break"
request.requestContent = "Miller break"
request.requestCount = 2
pm.apply(request)

request.requestContent = "Miller break"
request.requestCount = 4
pm.apply(request)

request.requestContent = "Miller break"
request.requestCount = 30
pm.apply(request)