import { Button, Form, Input, Radio } from "antd";
import { Link } from "react-router-dom";

function ResetMKComponent(){
    return (
    <div className="dangki">
    <div className="title">
      Đổi mật khẩu
    </div>
    <Form
    layout="vertical"
    name="form_in_modal"
    initialValues={{
      modifier: 'public',
    }}
    
  >
    <Form.Item
    name="token"
    label="Mã thay đổi"
    rules={[
        {
        required: true,
        message: 'Điền mã',
        },
    ]}
    className="in"
    >
    <Input style={{width:'300px'}}/>
    </Form.Item>
    <Form.Item
    name="mk"
    label="Mật khẩu mới"
    rules={[
        {
        required: true,
        message: 'Điền mật khẩu mới',
        },
    ]}
    className="in"
    >
    <Input style={{width:'300px'}}/>
    </Form.Item>

  </Form>
  <Button className="guibt">
    <Link to={"/dangnhap"}>Thay đổi</Link>
  </Button>
    </div>
    )
}
export default ResetMKComponent;