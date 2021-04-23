import QtQuick 2.0



Item {

    Rectangle {
        id: rectangle
        color: "#f4f4f4"
        anchors.fill: parent
        Timer {
            id: timer
        }





        function delay(delayTime, cb) {
            timer.interval = delayTime;
            timer.repeat = false;
            timer.triggered.connect(cb);
            timer.start();
        }
        Text {
            id: text1
            x: 200
            y: 459
            text: qsTr("0")
            anchors.left: parent.left
            anchors.right: parent.right
            anchors.top: rectangle.bottom
            anchors.bottom: parent.bottom
            font.pixelSize: 31
            anchors.rightMargin: -58
            anchors.leftMargin: 442
            anchors.bottomMargin: 119
            anchors.topMargin: -173
            minimumPixelSize: 25
        }

        Image {
            id: image
            opacity: 1
            visible: true

            anchors.left: parent.left
            anchors.right: parent.right
            anchors.top: parent.top
            anchors.bottom: parent.bottom
            horizontalAlignment: Image.AlignHCenter
            source: "../../../../Downloads/1 (1).svg"
            anchors.rightMargin: 132
            anchors.leftMargin: 93
            anchors.bottomMargin: 316
            anchors.topMargin: -84
            transformOrigin: Item.Top
            mirror: false
            smooth: false
            cache: false
            clip: true
            asynchronous: false
            sourceSize.width: 500
            fillMode: Image.Pad
        }

        Image {
            id: image1
            opacity: 0
            visible: true
            anchors.left: parent.left
            anchors.right: parent.right
            anchors.top: parent.top
            anchors.bottom: parent.bottom
            horizontalAlignment: Image.AlignHCenter
            source: "../../../../Downloads/2 (1).svg"
            smooth: false
            anchors.leftMargin: 93
            fillMode: Image.Pad
            clip: true
            sourceSize.width: 500
            transformOrigin: Item.Top
            mirror: false
            anchors.bottomMargin: 277
            asynchronous: false
            anchors.rightMargin: 211
            cache: false
            anchors.topMargin: -84
        }

/*##^## image 1 ve image 2 visible unvisible yapmamız için ##^##*/
        Component.onCompleted: {
            print("I'm printed right away..")
            delay(5000, function() {

                print("And I'm printed after 1 second!")
                image.opacity=0


                image1.opacity = 1
            })


        }







    }


}

/*##^##
Designer {
    D{i:0;autoSize:true;formeditorZoom:0.66;height:480;width:640}
}
##^##*/
