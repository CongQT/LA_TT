import { UserOutlined } from "@ant-design/icons";
import { Avatar, Button, Form, Input, Modal, Select, Space} from "antd"
import { useState } from "react";

const EditPhattu=({ open, onCreate, onCancel })=>{
    const [url,setUrl]=useState("http://www.4x4.ec/overlandecuador/wp-content/uploads/2017/06/default-user-icon-8.jpg")

    const handleAvatar=(e)=>{
        const file=e.target.files[0];
        file.preview=URL.createObjectURL(file)
        setUrl(file)
    }
    return <Modal
    width={700}
    open={open}
    title="Thông tin người dùng"
    okText="Cập nhật"
    cancelText="Bỏ qua"
    onCancel={onCancel}   
    onOk={() => {
      
    }}
  >
    <div>
      <div>
        <img src={url.preview} id="anh"/>
        <div>Ảnh đại diện người dùng</div>
        <Input id="chonanh" type="file" onChange={handleAvatar}/>
      </div>       
      <div className="editpt">
        <div style={{marginRight:'30px'}}>
            <div style={{marginBottom:'8px'}}>Họ tên</div>
            <Input style={{width:'300px'}} type="text"/>
        </div>
        <div>
            <div style={{marginBottom:'8px'}}>Pháp danh</div>
            <Input style={{width:'300px'}} type="text"/>
        </div>
      </div>
      <div className="editpt">
        <div style={{marginRight:'30px'}}>
            <div style={{marginBottom:'8px'}}>Email</div>
            <Input style={{width:'300px'}} type="text"/>
        </div>
        <div>
            <div style={{marginBottom:'8px'}}>Số điện thoại</div>
            <Input style={{width:'300px'}} type="text"/>
        </div>
       </div>
       <div  className="editpt">
        <div style={{marginRight:'30px'}}>
            <div style={{marginBottom:'8px'}}>Ngày sinh</div>
            <Input style={{width:'300px'}} type="date"/>
        </div>
        <div>
            <div style={{marginBottom:'8px'}}>Ngày xuất gia</div>
            <Input style={{width:'300px'}} type="date"/>
        </div>
       </div>
       <div className="editpt">
        <div style={{marginRight:'30px'}}>
            <div style={{marginBottom:'8px'}}>Giới tính</div>
            <Select style={{width:'200px'}}
            options={[
                {
                value: 'Nam',
                label: 'Nam',
                },
                {
                value: 'Nu',
                label: 'Nữ',
                },         
            ]}
            />
        </div>
        <div style={{marginRight:'30px'}}>
            <div style={{marginBottom:'8px'}}>Hoàn tục</div>
            <Select style={{width:'200px'}}
            options={[
                {
                value: 'dahoantuc',
                label: 'Đã hoàn tục',
                },
                {
                value: 'xuatgia',
                label: 'Xuất gia',
                },         
            ]}
            />
        </div>
        <div>
            <div style={{marginBottom:'8px'}}>Ngày hoàn tục</div>
            <Input style={{width:'200px'}} type="date"/>
        </div>
       </div>
    </div>
  </Modal>
}
export default EditPhattu